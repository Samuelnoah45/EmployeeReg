namespace PostgresDb.Models;
using PostgresDb.Entity;
using System.ComponentModel.DataAnnotations.Schema;
public class Driver : Person
{
    public Driver()
    {
        Cars = new HashSet<Car>();
    }
    public int TeamId { get; set; }
    
    [NotMapped]
    public string NameAndRacingNumber {get; set;} = "";
    public int RacingNumber { get; set; }
    public virtual Team Team { get; set; }
    public virtual DriverMedia DriverMedia { get; set; }

    public virtual ICollection<Car> Cars {get; set;}
}