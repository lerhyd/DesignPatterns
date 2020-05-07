using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApplication.AbstractFactoryImplementation
{
    /// <summary>
    /// Топливные баки автомобиля.
    /// Определяет общие свойства и методы, характерные для любого бака,
    /// не зависимо от того, к какому семейству он относитя.
    /// </summary>
    public interface ITank : IComponent
    {
        double MaxVolume { get; }
        double Volume { get; }
        bool Empty { get; }
        double SpeedFactor { get; }
        double Spend(double fuel);
    }
}
