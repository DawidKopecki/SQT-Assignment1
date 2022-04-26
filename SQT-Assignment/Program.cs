namespace SQT_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class InsuranceService
    {
        public float CalcPremium(int age, string location)
        {
            double premium;
            if (location == "rural")
                if ((age >= 18) && (age <= 30))
                    premium = 5.0;
                else
                if (age >= 31)
                    premium = 2.50;
                else
                    premium = 0.0;
            else
                if (location == "urban")
                    if ((age >= 18) && (age <= 35))
                        premium = 6.0;
                    else
                    if (age >= 36)
                        premium = 5.0;
                    else
                        premium = 0.0;
                else
                    premium = 0.0;
            if (age >= 50)
                premium = premium * 0.15;

            return (float)premium;
        }
    }
}
