using System;
namespace Problem11.Model
{
    public interface Entity<T>

    {
        T Id { get; set; }
    }
}
