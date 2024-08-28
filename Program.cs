using demoVS;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

builder.AddSerilog();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseLogTempo();

app.MapGet("/", () => "Hello World!");

app.MapGet("/teste", () =>{
    Thread.Sleep(1500); // Esperar 1500 milisegundos
    return "Teste 2";
});

app.Run();
