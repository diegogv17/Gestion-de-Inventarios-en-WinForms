using System;
using Gestor

namespace BaseData
{
    public static class Basedata
    {
        public static List<categoriesproductos> Getcategoriesproductos() => new()
        {
            new categoriesproductos { Id=1, Name="Individual", NightlyRate=180.00m, Capacity=1 },
            new categoriesproductos { Id=2, Name="Doble",      NightlyRate=260.00m, Capacity=2 },
            new categoriesproductos { Id=3, Name="Familiar",   NightlyRate=380.00m, Capacity=4 },
            new categoriesproductos { Id=4, Name="Suite",      NightlyRate=520.00m, Capacity=3 },
        };

        public static List<Service> GetServices() => new()
        {
            new Service { Id=1, Name="Desayuno buffet",       Price=45.00m },
            new Service { Id=2, Name="Transporte aeropuerto", Price=120.00m },
            new Service { Id=3, Name="Spa",                   Price=200.00m },
            new Service { Id=4, Name="WiFi premium",          Price=25.00m },
            new Service { Id=5, Name="Parqueo",               Price=30.00m },
        };
    }
}