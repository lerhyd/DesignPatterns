using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApplication.BaseImplementation
{
    /// <summary>
    /// Топливный бак автомобиля.
    /// </summary>
    public class Tank
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Максимально возможный объём бака (литры).
        /// </summary>
        public double MaxVolume { get; }

        /// <summary>
        /// Текущий объём топлива (литры).
        /// </summary>
        public double Volume { get; private set; }

        /// <summary>
        /// Стоимость.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; private set; }

        /// <summary>
        /// Осталось ли в баке топливо.
        /// </summary>
        public bool Empty => Volume == 0;

        /// <summary>
        /// Коэффициент ускорения в зависимости от полноты бака.
        /// Чем меньше топлива, тем меньше вес, тем выше скорость.
        /// </summary>
        public double SpeedFactor
        {
            get
            {
                var currentVolumePercent = Volume / MaxVolume;
                return -0.4 * currentVolumePercent + 1.2;
            }
        }

        /// <summary>
        /// Создать топливный бак.
        /// </summary>
        /// <param name="name"> Название. </param>
        /// <param name="maxVolume"> Максимальный объём (литры). </param>
        /// <param name="price"> Стоимость. </param>
        /// <param name="weight"> Вес. </param>
        public Tank(string name, double maxVolume, decimal price, double weight)
        {
            // TODO: проверка входных аргументов на корректность.
            Name = name;
            MaxVolume = maxVolume;
            Volume = maxVolume;
            Price = price;
            Weight = weight;
        }

        /// <summary>
        /// Потратить топливо
        /// </summary>
        /// <param name="fuel"> Запрашиваемое количество топлива. </param>
        /// <returns> Фактический процент потребления топлива. </returns>
        public double Spend(double fuel)
        {
            if (fuel <= Volume)
            {
                // Если в баке больше топлива, чем нужно, просто расходуем этот объём
                // и возвращаем 1 (100%).
                Volume -= fuel;
                return 1;
            }
            else
            {
                // Если в баке меньше, чем нужно, то расходуем всё, что есть,
                // и возвращаем процент от желаемого.
                var wayPercent = Volume / fuel;
                Volume = 0;
                return wayPercent;
            }
        }

        /// <summary>
        /// Приведение объекта к строке
        /// </summary>
        /// <returns> Название. </returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
