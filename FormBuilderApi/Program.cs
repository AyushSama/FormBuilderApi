using FormBuilder.Application.BuisnessInterfaces;
using FormBuilder.Application.BuisnessServices;
using FormBuilder.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContextPool<InboxContext>(options =>
    options.UseSqlServer("Server=AyushSama\\SQLEXPRESS;Database=tta_dev;Trusted_Connection=True;TrustServerCertificate=True;", sqloptions =>
    {
        sqloptions.CommandTimeout(5);
    }));

//builder.Services.AddScoped<IQuestionsAyushService,QuestionsAyushService>();
builder.Services.AddScoped<IAnswersAyushService,AnswersAyushService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
