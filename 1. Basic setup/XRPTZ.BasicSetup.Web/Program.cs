using Microsoft.EntityFrameworkCore;
using XRPTZ.BasicSetup.Web.Components;
using XRPTZ.BasicSetup.Web.Database;

var builder = WebApplication.CreateBuilder(args);

// Aspire client-integration
// builder.AddSqlServerDbContext<BasicSetupContext>(connectionName: "BasicSetup");

var connectionString = builder.Configuration.GetConnectionString("BasicSetup") ?? throw new InvalidOperationException("Connection string 'BasicSetup' not found.");
builder.Services.AddDbContextFactory<BasicSetupContext>(options => options.UseSqlServer(connectionString));

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
