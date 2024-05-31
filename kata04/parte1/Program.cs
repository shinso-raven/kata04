// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information





using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using LecturaDat;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------------Kata04-----------");

        const string filename = "C:\\Users\\radha\\OneDrive\\01 DESARROLLO\\Practicas de programación\\Tendencias desarollo de software\\Kata04\\kata04\\parte1\\Data\\weather.dat";

        //Stream stream = File.Open(filename, FileMode.Open);
        //BinaryFormatter bFormatter = new BinaryFormatter();
        //string respuesta= (string)bFormatter.Deserialize(stream);
        //stream.Close();

        LectorDAT lector = new LectorDAT();
        List<string[]> filas = lector.LeerArchivo(filename, 17);

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("parte 2");
        Console.WriteLine("-------------------------------------------------------");

        string[] resultado = lector.BuscarMinimo(filas);


        Console.WriteLine($"{resultado[0]} Max: {resultado[1]} MIn: {resultado[2]} diferencia: {resultado[3]}");









    }
    //static List<string[]> LeerArchivo(string filename)
    //{
    //    List<string[]> resultado = new List<string[]>();
    //    string[] lines = File.ReadAllLines(filename);

    //    int indice = 0;
    //    foreach (string line in lines)
    //    {
    //        if (indice == 0)
    //        {

    //            indice++;
    //            continue;
    //        }
    //        string objline = "";
    //        if (line.Length > 16)
    //        {

    //            objline = line.Remove(17);
    //            objline = objline.Trim();



    //            Console.Write(objline + "\t");


    //            string[] valores = objline.Split(" ");

    //            valores = System.Text.RegularExpressions.Regex.Split(objline, @"\s+");
    //            resultado.Add(valores);


    //            Console.Write($"numero de columnas: {valores.Length}\n");
    //            //Console.WriteLine("------------------");
    //            //foreach (string val in valores)
    //            //{
    //            //    Console.Write($"\n#{indice} ");
    //            //    Console.Write(val+ "\n");
    //            //}
    //            indice++;
    //        }
    //    }
    //    return resultado;
    //}
}