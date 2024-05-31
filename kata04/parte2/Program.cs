using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using LecturaDat;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string filename = "C:\\Users\\radha\\OneDrive\\01 DESARROLLO\\Practicas de programación\\Tendencias desarollo de software\\Kata04\\kata04\\parte2\\Data\\football.dat";



        Console.WriteLine("------------------------------------------");
        Console.WriteLine("parte 2");
        Console.WriteLine("------------------------------------------");


        Console.WriteLine("Numero de filas: " + filas.Count());




        LectorDAT lector = new LectorDAT();
        List<string[]> filas = lector.LeerArchivo(filename, 23, 43);

        //Buscar minimo
        List<string[]> listadoLimpio = new List<string[]>();
        string[] valores = { "", "", "" };

        foreach (string[] columans in filas)
        {
            if (columans[0].Contains( "---"))
                continue;

            valores = new string[]
            {
                columans[1],
                columans[2],
                columans[4]
            };

            listadoLimpio.Add(valores);
        }


        string[] resultado = lector.BuscarMinimo(listadoLimpio);

        //de 5 columnas a 3

        Console.WriteLine($"Equipo: {resultado[0]} For: {resultado[1]} Against: {resultado[2]} diferencia: {resultado[3]}");
    }



}