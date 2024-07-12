namespace TodolistBackend;

public  abstract class Entity<TID>:IEntity<TID> where TID : notnull
{
public Entity(TID iD){
    Id=iD;
}

    public TID Id {get;init;}
}
