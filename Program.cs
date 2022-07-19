using Scripture.Api.Configuration;
using Scripture.Api.Interfaces;
using Scripture.Api.Services;
const string AllowSpecificOrigins = "_allowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IBookService, BookService>();
builder.Services.AddSingleton<ITranslationService, TranslationService>();
builder.Services.AddSingleton<IVerseService, VerseService>();
//builder.Services.AddTransient<MySqlConnection>(_ => new MySqlConnection(builder.Configuration.GetConnectionString("Default"));
builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowSpecificOrigins,
        option =>
        {
            var corsOptions = builder.Configuration
                                        .GetSection("Cors")
                                        .Get<CorsOptions>();
            option.WithOrigins(corsOptions.Origins)
                .WithMethods(corsOptions.Methods)
                .AllowAnyHeader();
            if (corsOptions.AllowCredentials)
                option.AllowCredentials();

        });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app?.UseCors(AllowSpecificOrigins);
//Todo:Hide in productions if needed.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
