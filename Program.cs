namespace dz_6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1. Анонимный тип");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            var venus = new 
            { 
                Name = "Венера", 
                Number = 2, 
                EquatorLength = 38052, 
                PreviousPlanet = (string?) "null"
                
            };
                   
            Console.WriteLine("Название: " + venus.Name + "\n" + 
                "Номер от солнца: " + venus.Number + "\n" + 
                "Длина экватора: " + venus.EquatorLength + "\n" + 
                "Предыдущая планета: " + venus.PreviousPlanet);
            Console.WriteLine("Эквивалентна Венере?: " + venus.Equals(venus));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            var earth = new 
            { 
                Name = "Земля", 
                Number = 3, 
                EquatorLength = 40075,
                PreviousPlanet = venus 
            };

            Console.WriteLine("Название: " + earth.Name + "\n" + 
                "Номер от солнца: " + earth.Number + "\n" + 
                "Длина экватора: " + earth.EquatorLength + "\n" + 
                "Предыдущая планета: "  + earth.PreviousPlanet);
            Console.WriteLine("Эквивалентна Венере?:" + earth.Equals(venus));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            var mars = new
            {
                Name = "Марс",
                Number = 4,
                EquatorLength = 21165,
                PreviousPlanet = earth                 
            };
           
            Console.WriteLine("Название: " + mars.Name + "\n" + 
                "Номер от солнца: " + mars.Number + "\n" + 
                "Длина экватора: " + mars.EquatorLength + "\n" + 
                "Предыдущая планета: " + mars.PreviousPlanet);
            Console.WriteLine("Эквивалентна Венере?: " + mars.Equals(venus));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            var venus1 = new
            {
                Name = "Венера",
                Number = 2,
                EquatorLength = 38052,
                PreviousPlanet = (string?)"null"
            };
            
            Console.WriteLine("Название: " + venus1.Name + "\n" + 
                "Номер от солнца: " + venus1.Number + "\n" + 
                "Длина экватора: " + venus1.EquatorLength + "\n" + 
                "Предыдущая планета: " + venus1.PreviousPlanet);
            Console.WriteLine("Эквивалентна Венере?: " + venus1.Equals(venus)); 
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();


        }


    }
}



