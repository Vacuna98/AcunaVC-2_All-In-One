using myapi.Controllers;
using myapi.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AddingTwoNumbersService>();
builder.Services.AddScoped<AskingQuestionService>();
builder.Services.AddScoped<GuessItService>();
builder.Services.AddScoped<HelloWorldService>();
builder.Services.AddScoped<MadLibService>();
builder.Services.AddScoped<Magic8BallService>();
builder.Services.AddScoped<OddorEvenService>();
builder.Services.AddScoped<ResturantPickerService>();
builder.Services.AddScoped<ReverseItAlphaService>();
builder.Services.AddScoped<ReverseItNumService>();

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
