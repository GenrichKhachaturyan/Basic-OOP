using System;

namespace Homework5
{
    public class Homework5
    {
        public static void Main(string[] args)
        { 

            Rational r1 = new Rational(5, 10);
            Rational r2 = new Rational(5, 11);
            Rational r3 = new Rational(5, 10);

            Console.WriteLine(r1 <= r2);

            Console.WriteLine(r1.ToString());

        }
    }
}