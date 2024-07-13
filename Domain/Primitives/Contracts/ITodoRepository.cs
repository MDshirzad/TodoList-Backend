namespace TodolistBackend;

public interface ITodoRepository
{
Task<Todo> GetTodo(int id);
Task<IReadOnlyList<Todo>> GetTodos();
Task Create(Todo todo);
}
