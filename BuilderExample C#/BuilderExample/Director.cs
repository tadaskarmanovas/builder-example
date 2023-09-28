using BuilderExample.Builders;

namespace BuilderExample;

public class Director
{
    public void ConstructPassengerPlane(IAircraftBuilder aircraftBuilder)
    {
        aircraftBuilder.Reset();

        aircraftBuilder
            .AddCockpit()
            .AddEngine(6000)
            .AddWings()
            .AddBathroom()
            .AddPassengerSeats(126);
    }

    public void ConstructFighterPlane(IAircraftBuilder aircraftBuilder)
    {
        aircraftBuilder.Reset();

        aircraftBuilder
            .AddCockpit()
            .AddEngine(15000)
            .AddWings();
    }
}