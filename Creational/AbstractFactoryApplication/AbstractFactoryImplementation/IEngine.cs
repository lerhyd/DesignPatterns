using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApplication.AbstractFactoryImplementation
{
    /// <summary>
    /// Двигатели автомобилей.
    /// Определяет общие свойства и методы, характерные для любого автомобиля,
    /// не зависимо от того, к какому семейству он относится.
    /// </summary>
    public interface IEngine : IComponent
    {
        double MaxSpeed { get; }
        double GetConsumption(double speed);
    }
}
