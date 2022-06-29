using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using RpgSandbox.Auth;
using RpgSandbox.Common;

var builder = WebApplication.CreateBuilder(args);

var appSettings = builder.Configuration.GetSection("AppSettings");

builder.Services.Configure<AppSettings>(appSettings);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.RegisterServices(typeof(Program));

// data context
builder.Services.AddDbContext<RpgDataContext>(
    options =>
    {
        options.UseSqlite("name=DefaultConnection" );
    });

// Swagger with auth
var securityScheme = new OpenApiSecurityScheme()
{
    Name = "Authorization",
    Type = SecuritySchemeType.ApiKey,
    Scheme = "Bearer",
    BearerFormat = "JWT",
    In = ParameterLocation.Header,
    Description = "JSON Web Token based security",
};

var securityReq = new OpenApiSecurityRequirement()
{
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            }
        },
        Array.Empty<string>()
    }
};

var info = new OpenApiInfo()
{
    Version = "V1",
    Title = "RPG Sandbox",
    Description = "Just for fun",
    Contact = new OpenApiContact()
    {
        Name = "Gaby A",
        Email = "gaby@notanemail.com",
        Url = new Uri("https://gaby.com") 
    },
    License = new OpenApiLicense()
    {
        Name = "Free License",
    }
};

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", info);
    options.AddSecurityDefinition("Bearer", securityScheme);
    options.AddSecurityRequirement(securityReq);
});


// authentication and authorization

builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer (options => {
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidIssuer = appSettings["Issuer"],
        ValidAudience = appSettings["Audience"],
        ValidateAudience = false,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings["Secret"])),
        ValidateLifetime = false, // In any other application other then demo this needs to be true,
        ValidateIssuerSigningKey = true
    };
});

builder.Services.AddAuthorization();
// everything requires authentication unless otherwise specified
// builder.Services.AddAuthorization(options =>
// {
//     options.FallbackPolicy = new AuthorizationPolicyBuilder()
//         .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
//         .RequireAuthenticatedUser()
//         .Build();
// });

// build the app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

// middlewares
app.UseMiddleware<JwtMiddleware>();
app.UseMiddleware<ErrorHandlingMiddleware>();


// static file serving
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(appSettings["FilePath"]),
    RequestPath = "/images"
});
app.MapGet("/", () => "hello");

app.MapEndpoints(typeof(Program)); 

app.Run();