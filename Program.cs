

using Ceiberapp.Backend.Api.Db;
using Ceiberapp.Backend.Api.Models;


var builder = WebApplication.CreateBuilder(args);

#region Ruouting
builder.Services.AddControllers();
#endregion

#region Documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setupAction =>
{
    setupAction.SwaggerDoc(
        "v1",
        new Microsoft.OpenApi.Models.OpenApiInfo
        {
            Title = "CeiberApp API",
            Description = "Documentation de API CebierApp",
            Version = "v1",
        }
        );
});
#endregion

#region Storage
var connectionString = "Data Source=mssql-107024-0.cloudclusters.net,10243 ;Initial Catalog=ceiberapp;User ID=ceiber;Password=TECINF2k10$; TrustServerCertificate=True";
builder.Services.AddSqlServer<DbContextCeiberApp>(connectionString);
#endregion

var app = builder.Build();

//app.MapPost("/phone", (Phone phone) => { DbPhones.Phones.Add(phone); });

#region Dcomentation
app.UseSwagger();
app.UseSwaggerUI(C =>
{
    C.SwaggerEndpoint("/swagger/v1/swagger.json", "CeiberApp API v1");
});
#endregion

#region Ruouting
app.MapControllers();
#endregion

app.Run();
