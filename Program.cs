using NLog;
using NLog.Web;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
var builder = WebApplication.CreateBuilder(args);

//recuperando o DefaultConnection do appsettings
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//Adicionando a variável existente no NLog.config >> ${var:connectionString}"
NLog.LogManager.Configuration.Variables["connectionString"] = connectionString;

try
{
    //Adicionando Config NLog
    builder.Logging.ClearProviders();
    builder.Logging.AddConsole();

    builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
    builder.Host.UseNLog();

    builder.Services.AddControllersWithViews();



    var app = builder.Build();

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();
    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();


}
catch (Exception exception)
{
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    NLog.LogManager.Shutdown();
}