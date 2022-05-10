1 > Adicionando projeto
dotnet new mvc

2 > add package
https://www.nuget.org/packages/NLog.Web.AspNetCore/
dotnet add package NLog.Web.AspNetCore

https://www.nuget.org/packages/System.Data.SqlClient
dotnet add package System.Data.SqlClient --version 4.8.3

3 > criar arquivo de configuração NLOG
NLog.config
+ info 
https://nlog-project.org/ (Getting started for ASP.NET Core)

3.1 > alterar path do temp no xml "./log/nlog.txt"

3.2 > Adicionar o target do Database , baseado na query do INSERT DATABASE, e connectionString no appSettings

4> adicionar NLog na classe Program

5> SCRIPT
CREATE TABLE NLog(
    Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
    CreateDate datetime NOT NULL,
    Level nvarchar(10),
    Message nvarchar(max),
    StackTrace nvarchar(max),
    Exception nvarchar(max),
    Logger nvarchar(255),
    Url nvarchar(255)
);