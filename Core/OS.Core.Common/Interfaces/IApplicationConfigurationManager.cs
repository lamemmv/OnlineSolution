﻿namespace OS.Core.Common
{
    public interface IApplicationConfigurationManager
    {
        string GetConnectionString(string key);
    }
}
