// See https://aka.ms/new-console-template for more information





using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------------Kata04-----------");

        const string filename = "C:\\Users\\radha\\OneDrive\\01 DESARROLLO\\Practicas de programación\\Tendencias desarollo de software\\Kata04\\kata04\\Data\\weather.dat";

        //Stream stream = File.Open(filename, FileMode.Open);
        //BinaryFormatter bFormatter = new BinaryFormatter();
        //string respuesta= (string)bFormatter.Deserialize(stream);
        //stream.Close();

        List<string[]> filas = LeerArchivo(filename);

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("-------------------------------------------------------");

        //Console.WriteLine("\n" + filas.Count())


        double minimo = 1000;
        double diaM = 0, tempMaxM = 0, tempMinM = 0;


        int dia = 0;
        double tempMax = 0, tempMin = 0, diferencia = 0;
        string auxiliar = "";
        foreach (string[] columnas in filas)
        {

            //tomar el dia de columan 0
            try
            {

                auxiliar = columnas[0].Replace("*", "");
                dia = int.Parse(auxiliar);
            }
            catch (Exception ex)
            {
                dia = 0;

            }

            //tomar temp max de columan 1
            auxiliar = columnas[1].Replace("*", "");
            tempMax = double.Parse(auxiliar);

            //tomar tem min de columa 2dia  
            auxiliar = columnas[2].Replace("*", "");
            tempMin = double.Parse(auxiliar);

            diferencia = tempMax - tempMin;

            if (diferencia < minimo)
            {
                minimo = diferencia;
                diaM = dia;
                tempMaxM = tempMax;
                tempMinM = tempMin;

            }



        }
        Console.WriteLine($"{diaM} Max: {tempMaxM} MIn: {tempMinM} diferencia: {minimo}");









    }
    static List<string[]> LeerArchivo(string filename)
    {
        List<string[]> resultado = new List<string[]>();
        string[] lines = File.ReadAllLines(filename);

        int indice = 0;
        foreach (string line in lines)
        {
            if (indice == 0)
            {

                indice++;
                continue;
            }
            string objline = "";
            if (line.Length > 16)
            {

                objline = line.Remove(17);
                objline = objline.Trim();



                Console.Write(objline + "\t");


                string[] valores = objline.Split(" ");

                valores = System.Text.RegularExpressions.Regex.Split(objline, @"\s+");
                resultado.Add(valores);


                Console.Write($"numero de columnas: {valores.Length}\n");
                //Console.WriteLine("------------------");
                //foreach (string val in valores)
                //{
                //    Console.Write($"\n#{indice} ");
                //    Console.Write(val+ "\n");
                //}
                indice++;
            }
        }
        return resultado;
    }
}