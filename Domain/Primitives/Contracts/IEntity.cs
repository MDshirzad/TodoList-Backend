namespace TodolistBackend;

public interface IEntity<TID> where TID :  notnull
    {
        TID Id { get; }
    }
