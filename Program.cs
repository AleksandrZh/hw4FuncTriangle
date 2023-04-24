namespace hw4FuncTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flagExistence;
            int type;
            double a, b, c;
            Console.WriteLine($"Введите тип треугольника (1 - равтосторонний; 2 - не равносторонний)");
            type = int.Parse(Console.ReadLine());

            ;


            if (type == 2)
            {


                Console.WriteLine("a:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("c:");
                c = double.Parse(Console.ReadLine());

                flagExistence = (Operation.CalculateAreaTriangle(a, b, c) == 0);


                if (flagExistence)
                {
                    Console.WriteLine("Такого треугольника не существует, расчитать площадь невозможно");
                }
                else
                {
                    Console.WriteLine($"Площадь треугольника: {Operation.CalculateAreaTriangle(a, b, c)}");
                }





            }
            else if (type == 1)
            {
                Console.WriteLine("a:");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine($"Площадь треугольника: {Operation.CalculateAreaTriangle(a)}");

            }
            else
            {
                Console.WriteLine("Введено не верное заначение. До встречи!");
            }



        }
    }
}