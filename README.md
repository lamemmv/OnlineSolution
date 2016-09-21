# Online Solution
This is a simple solution for web API
## Installation instructions
- Create database namse **OS** or whatever you want.
- Run script Baseline.sql (DbScripts\Baseline.sql) on that database.
- Change connectionString in API\OS.Web.API\appsettings.json
'''
"ConnectionString": "Server=.\\SQL2008R2;Database=OS;Trusted_Connection=True;MultipleActiveResultSets=true"
''' 
- You can config port that is web API will be run on: API\OS.Web.API\Properties\launchSetting.json
- Chose OS.Web.API as startup project and run.