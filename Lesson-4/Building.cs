using System;
namespace Homework4
{
    sealed class Building
    {
        private static int numBuild = 1;

        private int number;

        private double height;

        private int floors;

        private int flats;

        private int entrance;

        
        internal Building(double height, int floors, int flats, int entrance)
        {
            //Установка номера здания
            this.number = numBuild++;
            //Установка высоты
            if (height < 0)
            {
                throw new Exception("You Input inccorrect values");
            }
            else
            {
                this.height = height;
            }
            //Установка этажей
            if (floors < 0 || floors > 17)
            {
                throw new Exception("You Input inccorrect values");
            }
            else
            {
                this.floors = floors;
            }
            //Установка квартир
            if (flats < 0)
            {
                throw new Exception("You Input inccorrect values");
            }
            else
            {
                this.flats = flats;
            }
            //установка подьездов
            if (entrance < 0)
            {
                throw new Exception("You Input inccorrect values");
            }
            else
            {
                this.entrance = entrance;
            }

        }

        internal Building()
        {
            this.number = numBuild++;
        }

        /// <summary>
        /// Высота каждого этажа
        /// </summary>
        /// <returns></returns>
        public double GetFloorHeightCalculation()
        {
            double heightFloor;
            heightFloor = Math.Round(this.height / this.floors,2);

            return heightFloor;
        }

        /// <summary>
        /// Вычисление кол-ва квартир в подьезде
        /// </summary>
        /// <returns></returns>
        public int GetFlatsInEntranceCalculation()
        {
            int flatsInEntrance;
            flatsInEntrance = this.flats / this.entrance;

            return flatsInEntrance;
        }

        /// <summary>
        /// Вычисление кол-ва квартир на этаже
        /// </summary>
        /// <returns></returns>
        public int GetFlatsInFloorCalculation()
        {
            int flatsInFloor = (this.flats / this.floors)/this.entrance;
            return flatsInFloor;
        }

        /// <summary>
        /// Установка этажей дома
        /// </summary>
        /// <param name="floors">Кол-во этажей</param>
        /// <exception cref="Exception">Кол-во не может быть больше 17 или меньше 1</exception>
        public void SetFloors(int floors)
        {
            if(floors < 0 || floors > 17)
            {
                throw new Exception("You Input inccorrect values");
            }
            else
            {
                this.floors = floors;
            }
        }
        /// <summary>
        /// Возращает кол-ва этажей
        /// </summary>
        /// <returns></returns>
        public int GetFloors()
        {
            return floors;
        }

        /// <summary>
        /// Установка кол-ва квартир
        /// </summary>
        /// <param name="flats">Кол-во квартир</param>
        /// <exception cref="Exception">Кол-во квартир не может быть меньше 1</exception>
        public void SetFlats(int flats)
        {
            if(flats < 0)
            {
                throw new Exception("You Input inccorrect values");
            }
            else
            {
                this.flats = flats;
            }
        }

        /// <summary>
        /// Возращает кол-ва квартир
        /// </summary>
        /// <returns></returns>
        public int GetFlats()
        {
            return flats;
        }

        /// <summary>
        /// Устанвока высоты здания
        /// </summary>
        /// <param name="height">Высота здания</param>
        /// <exception cref="Exception"> высота здания не может быть меньше 1</exception>
        public void SetHeight(double height)
        {
            if(height < 0)
            {
                throw new Exception("You Input inccorrect values");
            }
            else
            {
                this.height = height;
            }

            
        }
        /// <summary>
        /// Возращает высоту здания
        /// </summary>
        /// <returns></returns>
        public double GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Установка кол-ва подьездов
        /// </summary>
        /// <param name="entrance">Кол-во подьездов</param>
        /// <exception cref="Exception">Кол-во подьездов не может быть меньше 1</exception>
        public void SetEntrance(int entrance)
        {
            if(entrance < 0)
            {
                throw new Exception("You Input inccorrect values");
            }
            else
            {
                this.entrance = entrance;
            }
        }
        /// <summary>
        /// Возвращает кол-во подьездов
        /// </summary>
        /// <returns></returns>
        public int GetEntrance()
        {
            return entrance;
        }
        /// <summary>
        /// Возвращает номер дома
        /// </summary>
        /// <returns></returns>
        public int Number()
        {
            return number;
        }
    }
}

