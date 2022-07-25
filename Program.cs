

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IBook, BookService>();
//builder.Services.AddScoped(opts => new HttpClient { BaseAddress = new Uri("https://localhost:7192") });
builder.Services.AddFileReaderService(opts => opts.UseWasmSharedBuffer=true);
await builder.Build().RunAsync();
