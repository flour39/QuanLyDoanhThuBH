using QuanLyDoanhThuBH.Data;
using Microsoft.EntityFrameworkCore; // Add this using directive

var builder = WebApplication.CreateBuilder(args);

// đăng ký DbContext
builder.Services.AddDbContext<QuanLyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// services MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();
// ... pipeline
app.Run();