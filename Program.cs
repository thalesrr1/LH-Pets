var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto Web - LH Pets - Versão 1.0");

app.UseStaticFiles();

app.Run();
