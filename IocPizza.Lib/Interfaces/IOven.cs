namespace IocPizza.Lib
{
    public interface IOven
    {
        OvenFuelType OvenFuelType { get; set; }

        int OvenCubicInches { get; set; }
    }
}