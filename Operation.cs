namespace hw4FuncTriangle
{
    internal class Operation
    {

        private static bool CheckForExistenceTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double CalculateAreaTriangle(double a, double b, double c)
        {

            if (!CheckForExistenceTriangle(a, b, c))
                return 0;

            double p = ((a + b + c) / 2);

            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return s;

        }

        public static double CalculateAreaTriangle(double a)
        {

            double p = ((3 * a) / 2);
            double s = Math.Sqrt(p * Math.Pow((p - a), 2));
            return s;

        }


    }
}
