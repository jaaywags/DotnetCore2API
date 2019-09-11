Asp.Net Core 2 is open source
	https://github.com/aspnet/AspNetCore



Nuget Packages added are:
1. ...
2. NLog.Extensions.Logging & NLog.Web.AspNetCore
	-These are just logging nuget packages built for Asp.Net core 2. There are many. Look here for more: https://github.com/aspnet/Logging
3. Microsoft.EntityFrameworkCore.Tools
	-After installing this, I had to run the following command in Nuget Package Manager Console: Add-Migration CityInfoDBInitialMigration
		-Used to create migration files for database
		-Run this command after every database change. The thing after, Add-Migration, is just the description of the change. Run, Add-Migration DescriptionOfChangeHere


Connecting to database
-To prevent exposing the connection credentials for production in source control, you must add a user specific enviornment variable
	1. Go to windows
	2. Search "Environment Variables""
	3. Click it
	4. Click "Enviornment Variables..." button
	5. Add a new one for your user and not system
	6. Variable name, type, "connectionStrings:cityInfoDBConnectionString"
	7. Variable value, type, "Server=myproductionserver;Database=CityInfoDB;UserId=MyUsername;Password=MyPassword;"
		-Change accordingly
	8. Click ok, ok, ok
	9. Restart Visual Studio
	10. Set to Production and run and you will be using the production connection credentials
-After all that, it is still safer to encrypt the credentials in web.config;