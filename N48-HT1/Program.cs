using FileBaseContext.Context.Models.Configurations;
using N48_HT1.DataAccess;
using N48_HT1.Interfaces;
using N48_HT1.Services;

var builder = WebApplication.CreateBuilder(args);


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


//User(id, firstname, lastname, emailAddress, password)
//- Order(id, amount, userId)

//- modellarini qo'shing
//- DataAccess ni qo'shing ( IDataContext, AppFileContext )
//- shu modellar uchun servicelarni qo'shing
//- UserOrders nomli composition service qo'shing   m    m  m m      m  mmmmm m mmmm m mmm     m 