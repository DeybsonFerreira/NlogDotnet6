# NlogDotnet6
using NLog with .NET6 
Documentação NLog: https://nlog-project.org/
Documentação NLog: https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-6

### Adicionando projeto
```dotnet new mvc```

### Adicionando Pacotes
https://www.nuget.org/packages/NLog.Web.
```dotnet add package NLog.Web.AspNetCore```

https://www.nuget.org/packages/System.Data.SqlClient
``` dotnet add package System.Data.SqlClient ```

### criar arquivo de configuração NLOG
Precisamos criar um arquivo chamado ```NLog.config```

### SCRIPT no Database

```
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
```