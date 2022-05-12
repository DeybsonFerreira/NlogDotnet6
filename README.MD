# NlogDotnet6

Confira este repositório em artigo
https://medium.com/@deybsonferreira/nlog-com-net-6-5793f05de4a7

Confira em vídeo: clique abaixo 📺
[![Video](https://miro.medium.com/max/1400/1*xcCWailv5ImL2yLKf-7_wA.png)](https://youtu.be/m0X3FHWQf90)



# using NLog with .NET6 
Documentação NLog: https://nlog-project.org/ <br>
Documentação NLog: https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-6 <br>

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
