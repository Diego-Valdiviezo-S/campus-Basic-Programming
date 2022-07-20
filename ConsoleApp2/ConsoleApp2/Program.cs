using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {

            string InputFile;
            string OutputFile;

            DateTime actual = new DateTime();
            DateTime act = DateTime.Now;
            string month = act.ToString("MMMM");
            int year=act.Year;
            int day=act.Day;
            OutputFile = @"C:\Users\a875714\Documents\countries\Countries"+" "+year+"-"+month+"-"+day+".txt";
            InputFile = @"C:\Users\a875714\Documents\countries\countries.txt";
            GreetCountries(InputFile, OutputFile);
            Console.ReadKey();

        }

        public static void GreetCountries(string inputFile, string OutputFile)
        {
            string text;

            try {
                StreamWriter writer = new StreamWriter(OutputFile);
                StreamReader reader = new StreamReader(inputFile);

                {
                    text = reader.ReadLine();
                    while (text != null)
                    {

                        writer.WriteLine("Saludos hasta {0}!", text);
                        Console.WriteLine(text);
                        text = reader.ReadLine();
                    }
                    reader.Close();
                    writer.Close();
                }
                Console.ReadLine();
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Archivo no encontrado");
                Console.ReadKey();
            }

            catch (Exception e){
                Console.WriteLine("Ha ocurrido un error");
                Console.ReadKey();
            }
          
        }
    }
}
