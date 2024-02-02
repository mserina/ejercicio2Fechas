using System;

namespace ejercicio2Propiedades{

    class Program
    {

        static void Main(string[] args)
        {
            DateTime fechaHoy = DateTime.Now;

            Console.WriteLine("DIA");
            Console.WriteLine(fechaHoy.Day);
            
            Console.WriteLine(" ");
            Console.WriteLine("MES");
            Console.WriteLine(fechaHoy.Month);

            Console.WriteLine(" ");
            Console.WriteLine("AÑO");
            Console.WriteLine(fechaHoy.Year);

            Console.WriteLine(" ");
            Console.WriteLine("HORA");
            Console.WriteLine(fechaHoy.Hour);

            Console.WriteLine(" ");
            Console.WriteLine("MINUTOS");
            Console.WriteLine(fechaHoy.Minute);

            Console.WriteLine(" ");
            Console.WriteLine("SEGUNDOS");
            Console.WriteLine(fechaHoy.Second);
   
            Console.WriteLine(" ");
            Console.WriteLine("DIA DE LA SEMANA");
            Console.WriteLine(fechaHoy.DayOfWeek);

            Console.WriteLine(" ");
            Console.WriteLine("EL DIA DEL AÑO");
            Console.WriteLine(fechaHoy.DayOfYear);


        }
    }
}