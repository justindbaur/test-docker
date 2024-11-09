using Microsoft.AspNetCore.DataProtection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDataProtection();

var app = builder.Build();

app.MapGet("/data", (string data, IDataProtectionProvider dataProtectionProvider) =>
{
    return dataProtectionProvider.CreateProtector("Test").Protect(data);
});

app.Run();
