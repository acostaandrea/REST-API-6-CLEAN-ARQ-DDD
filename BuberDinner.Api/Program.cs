using BuberDinner.Api.Errors;
using BuberDinner.Api.Filters;
using BuberDinner.Api.Middleware;
using BuberDinner.Application;
using BuberDinner.Infraestructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
        
    /*builder.Services.AddControllers(options =>
    {
        options.Filters.Add<ErrorHandlingFilterAttribute>();
    });*/
    builder.Services.AddControllers();
   // builder.Services.AddSingleton<ProblemDetailsFactory, BuberDinnerProblemDetailsFactory>();
}


var app = builder.Build();

{
    //app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseExceptionHandler("/error");
    app.Map("/error", (HttpContext context) =>
    {
        Exception? exception = context.Features.Get<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature>()?.Error;
        return Results.Problem();
    });
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

