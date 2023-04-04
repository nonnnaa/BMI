using System;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            double height = Convert.ToDouble(Console.ReadLine());
            // height (m)
            double weight = Convert.ToDouble(Console.ReadLine());
            // weight (kg)
            double Bmi = Math.Round(weight / (Math.Pow(height, 2)), 1);
            //Console.WriteLine(Bmi);
            if(Bmi < 18)
            {
                Console.WriteLine("Underweight");
            }
            else if(Bmi < 25)
            {
                Console.WriteLine("Normal");
            }
            else if(Bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            } 
        }
    }
}