using System;

namespace Homework4
{
    public class Honework4
    {
        public static void Main(string[] args)
        {
            Building build = new Building(170,17,249,3);

            Console.WriteLine($"Высота каждого этажа:{build.GetFloorHeightCalculation()} метров.");
            Console.WriteLine($"Кол-во квартир на этаже: {build.GetFlatsInFloorCalculation()}");
            Console.WriteLine($"Кол-во квартир в подьезде: {build.GetFlatsInEntranceCalculation()}");

            


           

        }
    }
}