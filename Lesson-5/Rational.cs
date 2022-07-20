using System;
namespace Homework5
{
    public class Rational
    {
        private double numerator;

        private double denominator;

        public Rational(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Знаменатель не может хранить значение 0");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Rational() { }

        public double Numerator
        {
            get { return numerator; }
            set { this.numerator = value; }
        }

        public double Denominator
        {
            get { return denominator; }
            set { this.denominator = value; }
        }

        public static bool operator ==(Rational r1, Rational r2)
        {
            return (r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator);
        }
        public static bool operator !=(Rational r1, Rational r2)
        {
            return (r1.Numerator != r2.Numerator || r1.Denominator != r2.Denominator);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Rational))
                return false;

            Rational num = (Rational)obj;
            return numerator == num.numerator &&
                   denominator == num.denominator;
        }
        public static bool operator <=(Rational r1, Rational r2)
        {
            return (r1.Numerator <= r2.Numerator && r1.Denominator <= r2.Denominator);
        }
        public static bool operator >=(Rational r1, Rational r2)
        {
            return (r1.Numerator >= r2.Numerator && r1.Denominator >= r2.Denominator);
        }
        public static bool operator >(Rational r1, Rational r2)
        {
            //если рац числа правильные
            if (r1.Numerator < r1.Denominator && r2.Numerator < r2.Denominator)
            {
                //если знаменатели равны
                if (r1.Denominator == r2.Denominator)
                {
                    if (r1.Numerator > r2.Numerator)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                {
                    if (r1.Denominator < r2.Denominator)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
            else
            {
                //Если 1-ое рац число неправильное а 2-ое правильное
                if (r1.Numerator > r1.Denominator && r2.Numerator < r2.Denominator)
                    return true;
                //Если 1-ое рац число правильное а 2-ое нет
                if (r1.Numerator < r1.Denominator && r2.Numerator > r2.Denominator)
                    return false;
                //Если 2 рац числа неправильные
                if (r1.Numerator > r1.Denominator && r2.Numerator > r2.Denominator)
                {
                    if (r1.Numerator > r2.Numerator)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }

        }
        public static bool operator <(Rational r1, Rational r2)
        {
            //если рац числа правильные
            if (r1.Numerator < r1.Denominator && r2.Numerator < r2.Denominator)
            {
                //если знаменатели равны
                if (r1.Denominator == r2.Denominator)
                {
                    if (r1.Numerator > r2.Numerator)
                    {
                        return false;
                    }
                    else
                        return true;
                }
                else
                {
                    if (r1.Denominator < r2.Denominator)
                    {
                        return false;
                    }
                    else
                        return true;
                }
            }
            else
            {
                //Если 1-ое рац число неправильное а 2-ое правильное
                if (r1.Numerator > r1.Denominator && r2.Numerator < r2.Denominator)
                    return false;
                //Если 1-ое рац число правильное а 2-ое нет
                if (r1.Numerator < r1.Denominator && r2.Numerator > r2.Denominator)
                    return true;
                //Если 2 рац числа неправильные
                if (r1.Numerator > r1.Denominator && r2.Numerator > r2.Denominator)
                {
                    if (r1.Numerator > r2.Numerator)
                        return false;
                    else
                        return true;
                }
                else
                    return true;
            }


        }
        public static Rational operator +(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator + r2.Numerator,r1.Denominator + r2.Denominator);
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator - r2.Numerator, r1.Denominator - r2.Denominator);
        }
        public static Rational operator --(Rational r1)
        {
            r1.Numerator--;
            r1.Denominator--;
            return r1;
        }
        public static Rational operator ++(Rational r1)
        {
            r1.Numerator++;
            r1.Denominator++;
            return r1;
        }
        public override string ToString()
        {
            if (numerator == 0)
            {
                return "0";
            }

            if (numerator == denominator)
            {
                return "1";
            }
            if (denominator == 1)
            {
                return numerator.ToString();
            }
            return numerator + "/" + denominator;
        }
    }
}

