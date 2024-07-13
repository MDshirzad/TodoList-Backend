
namespace TodolistBackend;

public class TodoService:ITodoService
{
    private readonly ITodoRepository _todoRepository;
    public TodoService(ITodoRepository todoRepository) => this._todoRepository=todoRepository;

    public Task Create(Todo todo)
    {
        return Task.FromResult("");
    }

    public Task<Todo> GetTodo(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Todo>> GetTodos()
    {
        throw new NotImplementedException();
    }
}
