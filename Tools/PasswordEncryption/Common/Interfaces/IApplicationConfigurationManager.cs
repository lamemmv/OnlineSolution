﻿namespace PasswordEncryption.Common
{
    public interface IApplicationConfigurationManager
    {
        string GetConnectionString(string key);
        string GetString(string key);

        bool GetBoolean(string key, bool defaultValue = false);

        int GetInteger(string key, int defaultValue = 0);

        T GetEnum<T>(string key, T defaultValue) where T : struct;        
    }
}
