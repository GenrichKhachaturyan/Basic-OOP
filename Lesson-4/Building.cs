using System;
namespace Homework4
{
    public class Building
    {
        private byte number = numBuild;
        private byte height;
        private byte floors;
        private short flats;
        private byte entrance;

        static byte numBuild = 1;




        public Building(byte height,byte floors,short flats, byte entrance)
        {
            CreateNumBuilding();
            //установка высоты
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

        public Building()
        {
            CreateNumBuilding();
        }

        /// <summary>
        /// Высота каждого этажа
        /// </summary>
        /// <returns></returns>
        public float GetFloorHeightCalculation()
        {
            float heightFloor;
            heightFloor = this.height / this.floors;

            return heightFloor;
        }

        /// <summary>
        /// Вычисление кол-ва квартир в подьезде
        /// </summary>
        /// <returns></returns>
        public short GetFlatsInEntranceCalculation()
        {
            short flatsInEntrance;
            flatsInEntrance = (short)(this.flats / this.entrance);

            return (short)flatsInEntrance;
        }

        /// <summary>
        /// Вычисление кол-ва квартир на этаже
        /// </summary>
        /// <returns></returns>
        public short GetFlatsInFloorCalculation()
        {
            short flatsInFloor = (short)((this.flats / this.floors)/this.entrance);
            return flatsInFloor;
        }

        /// <summary>
        /// Установка этажей дома
        /// </summary>
        /// <param name="floors">Кол-во этажей</param>
        /// <exception cref="Exception">Кол-во не может быть больше 17 или меньше 1</exception>
        public void SetFloors(byte floors)
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
        public byte GetFloors()
        {
            return floors;
        }

        /// <summary>
        /// Установка кол-ва квартир
        /// </summary>
        /// <param name="flats">Кол-во квартир</param>
        /// <exception cref="Exception">Кол-во квартир не может быть меньше 1</exception>
        public void SetFlats(short flats)
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
        public short GetFlats()
        {
            return flats;
        }

        /// <summary>
        /// Устанвока высоты здания
        /// </summary>
        /// <param name="height">Высота здания</param>
        /// <exception cref="Exception"> высота здания не может быть меньше 1</exception>
        public void SetHeight(byte height)
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
        public byte GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Установка кол-ва подьездов
        /// </summary>
        /// <param name="entrance">Кол-во подьездов</param>
        /// <exception cref="Exception">Кол-во подьездов не может быть меньше 1</exception>
        public void SetEntrance(byte entrance)
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
        public byte GetEntrance()
        {
            return entrance;
        }
        /// <summary>
        /// Возвращает номер дома
        /// </summary>
        /// <returns></returns>
        public byte Number()
        {
            return number;
        }

        /// <summary>
        /// Инициализирует уникальный номер дома
        /// </summary>
        private void CreateNumBuilding()
        {
            numBuild++;
        }
    }
}

