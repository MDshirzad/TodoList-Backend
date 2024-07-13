
namespace TodolistBackend;

public class TodoRepository : ITodoRepository
{
    public Task Create(Todo todo)
    {
        throw new NotImplementedException();
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
