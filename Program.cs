using System;

class Program
{
    static void Main(string[] args)
    {

        Auto Auto = new Auto("Nissan", "Toyota", 2025, 130000, 4);
        Motocicleta Moto = new Motocicleta("Yamaha", "Honda", 2024, 62000, "Cruiser");
        Camion Camion = new Camion("Renault", "Volvo", 2019, 136500, 10);


        Console.WriteLine($"Auto: {Auto.Marca} {Auto.Modelo}, Año: {Auto.Año}, Puertas: {Auto.NumeroDePuertas}");
        Auto.Encender();
        Auto.Conducir(100);
        Auto.Apagar();

        Console.WriteLine($"Motocicleta: {Moto.Marca} {Moto.Modelo}, Año: {Moto.Año}, Tipo: {Moto.TipoDeMoto}");
        Moto.Encender();
        Moto.Conducir(65);
        Moto.Apagar();

        Console.WriteLine($"Camión: {Camion.Marca} {Camion.Modelo}, Año: {Camion.Año}, Capacidad de Carga: {Camion.CapacidadDeCarga} toneladas");
        Camion.Encender();
        Camion.Conducir(3000);
        Camion.Apagar();
    }
}

