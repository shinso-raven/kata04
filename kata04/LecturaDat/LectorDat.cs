namespace LecturaDat
{
    public class LectorDAT
    {

        public List<string[]> LeerArchivo(string filename, int removerInicio, int removerFinal = 0)
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

                    //buscar un caracter de inicio de la columna

                    if (removerFinal == 0)
                    {
                        objline = line.Remove(removerInicio);
                    }
                    else
                    {

                        objline = line.Remove(removerInicio, removerFinal - removerInicio);
                    }


                    objline = objline.Trim();



                    Console.Write(objline + "\t");


                    string[] valores = objline.Split(" ");

                    valores = System.Text.RegularExpressions.Regex.Split(objline, @"\s+");
                    resultado.Add(valores);


                    Console.Write($"numero de columnas: {valores.Length}\n");
                    Console.WriteLine("------------------");
                    indice++;
                }
            }

            Console.WriteLine("------------------REFERENCIA--------------");
            int contador = 0;
            foreach (string val in resultado[0])
            {
                Console.Write($"\n#{contador} ");
                Console.Write(val + "\n");
                contador++;
            }

            return resultado;
        }


        public string[] BuscarMinimo(List<string[]> datos)
        {

            /*
            Metodo que recibe un string[3] nombre, max, min
             */

            string nombre = "";
            double max = 0, min = 0;
            double diferencia = 0;
            string auxiliar = "";


            string nombreFinal = "";
            double maxFInal = 0, minFinal = 0;


            double minimo = 100000000000;

            foreach (string[] columnas in datos)
            {

                if (columnas[0].Contains("---"))
                {
                    continue;
                }
                ////tomar el dia de columan 0
                try
                {

                    auxiliar = columnas[0].Replace("*", "");
                    nombre = auxiliar;
                }
                catch (Exception ex)
                {
                    nombre = "";

                }

                //tomar temp max de columan 1
                auxiliar = columnas[1].Replace("*", "");
                max = double.Parse(auxiliar);

                //tomar tem min de columa 2dia  
                auxiliar = columnas[2].Replace("*", "");
                min = double.Parse(auxiliar);

                diferencia = max - min;

                if (diferencia < 0)
                    diferencia *= -1;

                if (diferencia < minimo)
                {
                    minimo = diferencia;
                    nombreFinal = nombre;
                    maxFInal = max;
                    minFinal = min;

                }



            }

            string[] resultado = { nombreFinal, maxFInal.ToString(), minFinal.ToString(), minimo.ToString() };

            return resultado;



        }
    }
}