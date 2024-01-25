using DesignPatterns.Models;

namespace DesignPatterns.Models.Builder
{
    public interface IVehicleBuilder
    {
        IVehicleBuilder SetColor(string color);
        IVehicleBuilder SetBrand(string brand);
        IVehicleBuilder SetModel(string model);
        IVehicleBuilder SetFuelLimit(double fuelLimit);

        Vehicle Build();
    }
}
