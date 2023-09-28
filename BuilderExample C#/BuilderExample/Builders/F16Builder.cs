using BuilderExample.Models;

namespace BuilderExample.Builders;

public class F16Builder : IAircraftBuilder
{
    private F16 _aircraft = new();

    public void Reset()
    {
        _aircraft = new F16();
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
        throw new NotImplementedException();
    }

    public IAircraftBuilder AddPassengerSeats(int numberOfSeats)
    {
        throw new NotImplementedException();
    }

    public F16 GetResult() => _aircraft;
}