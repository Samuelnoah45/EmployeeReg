namespace PostgresDb.Entity;

using PostgresDb.Models;
public class Person:BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Age { get; set; }
}