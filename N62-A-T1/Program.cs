using FileBaseContext.Context.Models.Configurations;
using N48_HT1.DataAccess;
using N62_A_T1.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<IFileContextOptions<AppFileContext>>(_ => new FileContextOptions<AppFileContext>
//{
//    StorageRootPath = Path.Combine(builder.Environment.ContentRootPath, "Data", "DataStorage")
//});

//builder.Services.AddSingleton<AppFileContext>();


builder.Services.AddSwaggerGen().AddEndpointsApiExplorer();
var assemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies().Select(Assembly.Load).ToList();

assemblies.Add(Assembly.GetExecutingAssembly());

builder.Services.AddAutoMapper(assemblies);

builder.Services.AddSingleton<IDataContext, AppFileContext>(_ =>
{
    var options = new FileContextOptions<AppFileContext>
    {
        StorageRootPath = Path.Combine(builder.Environment.ContentRootPath, "Data", "DataStorage")
    };

    var context = new AppFileContext(options);

    context.FetchAsync().AsTask().Wait();

    return context;
});


builder.Services.AddSingleton<UserService>();
builder.Services.AddControllers();


var app = builder.Build();

app.UseSwagger().UseSwaggerUI();

app.MapControllers();


app.Run();
