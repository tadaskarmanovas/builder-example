namespace BuilderExample.Models;

public interface IPassengerPlane
{
    object Engine { get; set; }
    object Wings { get; set; }
    object Cockpit { get; set; }
    object Bathroom { get; set; }
    List<object> Seats { get; set; }
}