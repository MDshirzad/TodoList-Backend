namespace TodolistBackend;
 
public class Todo:Entity<int>
{
    public string Title { get; init; }
    public string Description { get; init; }
    public bool IsDone{ get; init; }

 
    public Todo(string title,string description,bool isDone):base(0){
        this.Title = title;
        this.Description = description;
        this.IsDone = isDone;
        
    }

}
