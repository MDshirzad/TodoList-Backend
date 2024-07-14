namespace TodolistBackend;

public class FakeTodolistRepository
{

     private static List<Todo> _instance;    

 

    public static  List<Todo>  Todos
    {
        get
        {
            if(_instance == null)
                _instance = new  List<Todo> ();

            return _instance;
        }
    }

}
