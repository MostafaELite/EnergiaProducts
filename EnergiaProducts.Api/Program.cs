using EnergiaProducts.Api.Config;

var builder = WebApplication.CreateBuilder(args);
ServiceRegisteration.RegisterServices(builder);

var app = builder.Build();
PipelineConfig.Configure(app);

app.Run();
