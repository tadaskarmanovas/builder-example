using BuilderExample.Builders;

namespace BuilderExample;

public class Client
{
    public void Run()
    {
        var director = new Director();
        // Building Airbus A380
        var airbusA380Builder = new AirbusA380Builder();
        director.ConstructPassengerPlane(airbusA380Builder);
        var airbusA380 = airbusA380Builder.GetResult();

        director.ConstructFighterPlane(airbusA380Builder);
        var airbusA380WithStrongerEngine = airbusA380Builder.GetResult();

        // Building Boeing 747
        var boeing747Builder = new Boeing747Builder();
        director.ConstructPassengerPlane(boeing747Builder);

        var boeing747 = boeing747Builder.GetResult();

        // Building F16
        var f16Builder = new F16Builder();
        director.ConstructFighterPlane(f16Builder);

        var f16 = f16Builder.GetResult();

        director.ConstructPassengerPlane(f16Builder); // this will through because F16 is not capable to have seats & bathrooms
    }
}