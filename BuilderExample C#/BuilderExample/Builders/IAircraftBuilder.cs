namespace BuilderExample.Builders
{
    public interface IAircraftBuilder
    {
        public IAircraftBuilder AddEngine(int horsepower);

        public IAircraftBuilder AddWings();

        public IAircraftBuilder AddCockpit();

        public IAircraftBuilder AddBathroom();

        public IAircraftBuilder AddPassengerSeats(int numberOfSeats);

        public void Reset();
    }
}