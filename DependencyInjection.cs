using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TodolistBackend;

public static class DependencyInjection
{
    public static void AddTodoServices(this IServiceCollection  services, IConfiguration configuration){
         services.AddScoped<ITodoRepository,TodoRepository>();
        
        services.AddScoped<ITodoService,TodoService>();

    }

}
