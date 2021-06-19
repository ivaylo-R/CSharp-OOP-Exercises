namespace Vehicles.Contracts
{
    public interface IDrivable
    {
        string Drive(double distance);

        string DriveEmpty(double distance);
    }
}
