
using Microsoft.EntityFrameworkCore;
using SchoolAppCore.Models;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký Razor Pages
builder.Services.AddRazorPages();

// Kết nối SchoolDB_Lab06
builder.Services.AddDbContext<SchoolContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString(
            "SchoolDBConnectionString"
        )
    )
);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
