using GestionProductos.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<ProductosService>();
builder.Services.AddSingleton<CategoriasService>();

var app = builder.Build();

//app.UseHttpsRedirection();


app.UseRouting();

app.UseAuthorization();

app.MapControllers();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
