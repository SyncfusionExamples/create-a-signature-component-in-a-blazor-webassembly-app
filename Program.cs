using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazorApp;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Your License Key");
builder.Services.AddSyncfusionBlazor(options => options.IgnoreScriptIsolation = true);

await builder.Build().RunAsync();
