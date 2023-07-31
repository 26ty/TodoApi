using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); // 用於處理 HTTP 請求

/* 使用 AddDbContext 方法來註冊 TodoContext 類別，
 * 使用 UseInMemoryDatabase 方法來指定使用內存資料庫，
 * 資料庫指定名稱 "TodoList"。*/
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer(); // 提供了有關應用程式路由和端點的信息

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// 啟用 Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 用於啟用 HTTPS 重定向
app.UseHttpsRedirection();

// 有經過驗證的使用者才能訪問受保護的資源
app.UseAuthorization();

// 將控制器映射到 URL
app.MapControllers();

// 用於啟動應用程式。它告訴應用程式開始接收並處理 HTTP 請求
app.Run();

