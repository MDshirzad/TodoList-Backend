using Carter;

namespace TodolistBackend;

public class TodosEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var mapper = app.MapGroup("/todo");
        mapper.MapGet("/get-all-todos", GetAllTodos);
        mapper.MapPost("create",CreateTodo);
    }

    private async Task CreateTodo(AddTodoRequest addTodo )
    {
         var todo = await Task.FromResult("");
    }

    private async Task<List<ReadTodoResponse>> GetAllTodos()
    {
        
       var req1 = new ReadTodoResponse("Hi","chaisdas",false);
       var req2 = new ReadTodoResponse("Hi","chaisdas",true);
       var list = new List<ReadTodoResponse>(){req1,req2};
       return await Task.FromResult(list);
    }
}
