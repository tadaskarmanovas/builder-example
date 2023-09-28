using BuilderExample.Models;

namespace BuilderExample.Builders;

public class AirbusA380Builder : IAircraftBuilder
{
    private AirbusA380 _aircraft = new();

    public void Reset()
    {
        _aircraft = new AirbusA380();
    }

    public IAircraftBuilder AddEngine(int horsepower)
    {
        _aircraft.Engine = new Engine(horsepower);
        return this;
    }

    public IAircraftBuilder AddWings()
    {
        _aircraft.Wings = new object();
        return this;
    }

    public IAircraftBuilder AddCockpit()
    {
        _aircraft.Cockpit = new object();
        return this;
    }

    public IAircraftBuilder AddBathroom()
    {
        _aircraft.Bathroom = new object();
        return this;
    }

    public IAircraftBuilder AddPassengerSeats(int numberOfSeats)
    {
        var aircraftSeats = new List<object>();

        for (var i = 0; i < numberOfSeats; i++)
        {
            aircraftSeats.Add(new object());
        }

        _aircraft.Seats = aircraftSeats;

        return this;
    }

    public AirbusA380 GetResult()
    {
        return _aircraft;
    }
}