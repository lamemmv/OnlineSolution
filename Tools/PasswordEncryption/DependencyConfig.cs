using PasswordEncryption.Common;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PasswordEncryption
{
    public static class DependencyConfig
    {
        private static readonly Dictionary<Type, Lifestyle> m_AutoRegistrationLifestyles = new Dictionary<Type, Lifestyle>();

        public static void RegisterContainer(Container container)
        {
            RegisterDependencies(container);
        }

        private static void RegisterDependencies(Container container)
        {
            RegisterCommonDependencies(container);
        }

        private static void RegisterCommonDependencies(Container container)
        {
            RegisterInterfacesWithSingleImplementation(container, (typeof(IApplicationConfigurationManager)).Assembly); // Common
        }

        private static void RegisterInterfacesWithSingleImplementation(Container container, Assembly interfaceAssembly, params Assembly[] targetAssemblies)
        {
            dynamic registrations = GetSimpleImplementationRegistrations(interfaceAssembly, targetAssemblies);

            foreach (var registration in registrations)
            {
                Lifestyle lifestyle;
                if (!m_AutoRegistrationLifestyles.TryGetValue(registration.Interface, out lifestyle))
                {
                    lifestyle = Lifestyle.Singleton; // This is default
                }

                if (lifestyle != null) // This is non-registerable exceptions
                {
                    container.Register(registration.Interface, registration.Implementation, lifestyle);
                }
            }
        }

        private static IEnumerable<dynamic> GetSimpleImplementationRegistrations(Assembly interfaceAssembly, params Assembly[] targetAssemblies)
        {
            IEnumerable<Type> interfaces = interfaceAssembly.GetExportedTypes()
                                                            .Where(t => t.IsInterface);

            if (targetAssemblies.Length == 0)
            {
                targetAssemblies = new[] { interfaceAssembly };
            }

            Type[] allTypes = targetAssemblies.SelectMany(a => a.GetTypes())
                                              .Where(t => t.IsClass)
                                              .ToArray();

            return interfaces.Select(i => new
            {
                Interface = i,
                Implementation = GetSingleImplementation(i, allTypes)
            })
                             .Where(r => r.Implementation != null &&
                                         !r.Interface.IsGenericType);

        }

        private static Type GetSingleImplementation(Type interfaceType, Type[] types)
        {
            Type result = null;
            foreach (var type in types)
            {
                if (interfaceType.IsAssignableFrom(type))
                {
                    if (result != null) // Second implementation found
                    {
                        result = null;
                        break;
                    }

                    result = type;
                }
            }

            if (result != null && result.GetInterfaces().Length > 1) // We cannot register a type with 2 interfaces, but we still need it to be in types to check for more than one implementation
            {
                result = null;
            }

            return result;
        }
    }
}
