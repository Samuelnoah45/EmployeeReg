namespace PostgresDb.Models;

public class Car: BaseEntity{
    public string Name { get; set; }
    public string Model { get; set; }
    public int CC { get; set; }
    public int PlateNumber {get; set;}
    public int DriverId {get; set;}
    public virtual Driver Driver {get; set;}
}