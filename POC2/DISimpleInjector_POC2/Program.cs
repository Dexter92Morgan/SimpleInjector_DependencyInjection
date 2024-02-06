using DISimpleInjector_POC2.Interface.Repository;
using DISimpleInjector_POC2.Repository;
using Microsoft.AspNetCore.Mvc.Controllers;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region SimpleInjector

//Create a new Simple Injector Container 

var container = new Container();
container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
container.Options.EnableAutoVerification = false;

builder.Services.AddMvcCore();

object value = builder.Services.AddSimpleInjector(container, options =>
{
    options.AddAspNetCore().AddControllerActivation(Lifestyle.Transient); // Lifestyle Transient due to controllers not supposed to be otherwise, more here: https://github.com/dotnet/aspnetcore/issues/20551
});

builder.Services.AddHttpContextAccessor();

builder.Services.AddSingleton(container);

container.Register<ICustomerRepository, CustomerRepository>();

#endregion



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


// Reference Document 
//https://www.youtube.com/watch?v=wMVfUbPTmjo
//https://www.c-sharpcorner.com/UploadFile/4d9083/dependency-injection-using-simple-injector/   