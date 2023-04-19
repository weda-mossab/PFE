using AzureFormRecog.Data;
using AzureFormRecog.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.FileProviders;
using Blazored.Modal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IFileUpload, FileUpload>();
builder.Services.AddBlazoredModal();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor().AddHubOptions(o => { o.MaximumReceiveMessageSize = 102400000; });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

//  app.UseStaticFiles(new StaticFileOptions
//  {
//      FileProvider = new PhysicalFileProvider(
//          Path.Combine(@"C:\Users\Weda\Desktop\FormRecog\AzureFormRecog\", "UploadloadedFiles"))
//  });

app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
