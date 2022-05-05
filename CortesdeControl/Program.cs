using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CortesdeControl
{
    class Program
    {
        public List<Persona> listA = new List<Persona>();
        static string leerControl(Persona p)
        {
            //Persona p = new Persona();

            bool f = false;
            string date="";
            do
            {             

                
                try
                {
                    int d, m, y;
                    Console.WriteLine($"Ingrese la fecha del dia del proceso de {p.nombre}:");
                    Console.Write("Dia: ");
                    d = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Mes: ");
                    m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Año:");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (d >= 1 && d <= 30 && m < 13 && m > 0 && y > 2010 && y < 2014)
                    {
                        date = $"{d}-{m}-{y}";
                        f = true;
                        //l.listA.Add()
                    }
                    else
                    {
                        Console.WriteLine("fecha no valida");                        
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Ingreso un dato invalido!!");
                }
            } while (f != true);

            //p.fechaUltProceso = date;
            
            Console.WriteLine(date);
            return date;
        }

        static void lecturaPersonal(Program l)
        {
            var reader = new StreamReader(@"C:\Users\fedec\source\repos\Bootcamp_2\Bootcamp_2\bin\Debug\netcoreapp3.1\archivo.csv");
            


            while (!reader.EndOfStream)
            {
                Persona p = new Persona();
                var line = reader.ReadLine();
                var values = line.Split(';');

                p.legajo = int.Parse(values[0]);
                p.nombre = values[1];
                p.hora = values[2];
                p.horasTrabajadas = int.Parse(values[3]);
                p.sueldosaCobrar = int.Parse(values[4]);
                p.fechaUltProceso = leerControl(p);
                l.listA.Add(p);
            }

            foreach (var coloumn1 in l.listA)
            {
                Console.WriteLine(coloumn1.legajo+"   "+coloumn1.nombre + "   " + coloumn1.hora+"   "
                    + coloumn1.horasTrabajadas+"   "+coloumn1.sueldosaCobrar +"   " + coloumn1.fechaUltProceso);
            }

        }


        static void Main(string[] args)
        {
            Program lista = new Program();
            Persona ej = new Persona();
            Console.WriteLine("~·~·~·~·~·~·~·~·~\n|Corte de control|\n~·~·~·~·~·~·~·~·~\n");
            
            
            bool f = false;
            int option = 0;
            do
            {
                Console.WriteLine("0- Apagar\n1- ejercicio 1\n2- Pair Pogramming 2\n");
                string s = Console.ReadLine();
                try
                {
                    option = int.Parse(s);
                    f = true;

                }
                catch (Exception)
                {

                    Console.WriteLine("Ingreso un dato invalido!!");
                }
            } while (f != true);

            while (option != 0)
            {
                switch (option)
                {
                    case 1:
                        {
                            lecturaPersonal(lista);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("NUMERO INVALIDO");
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
                do
                {
                    Console.WriteLine("0- Apagar\n1- ejercicio 1\n2- Pair Pogramming 2\n");
                    string s = Console.ReadLine();
                    try
                    {
                        option = int.Parse(s);
                        f = true;

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Ingreso un dato invalido!!");
                    }
                } while (f != true);

            }

        }
    }

    public class Persona
    {
        public int legajo { get; set; }
        public string nombre { get; set; }
        public string fechaUltProceso { get; set; }
        public string hora { get; set; }
        public double horasTrabajadas { get; set; }
        public int sueldosaCobrar { get; set; }


        

    }
    interface fede
    {

    }
}
