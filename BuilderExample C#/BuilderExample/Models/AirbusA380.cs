namespace BuilderExample.Models;

public class AirbusA380 : IPassengerPlane
{
    public object Engine { get; set; }
    public object Wings { get; set; }
    public object Cockpit { get; set; }
    public object Bathroom { get; set; }
    public List<object> Seats { get; set; }
}