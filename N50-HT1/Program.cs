using FileBaseContext.Context.Models.Configurations;
using N50_HT1.DataAccess;
using N50_HT1.Interfaces;
using N50_HT1.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IDataContext, AppFileContext>(_ =>
{
    var options = new FileContextOptions<AppFileContext>
    {
        StorageRootPath = Path.Combine(builder.Environment.ContentRootPath, "Data", "Storage")
    };

    var context = new AppFileContext(options);

    context.FetchAsync().AsTask().Wait();

    return context;
});

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IUserOrderService, UserOrdersService>();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


var app = builder.Build();

app.MapControllers();
app.UseSwagger().UseSwaggerUI();

app.Run();
