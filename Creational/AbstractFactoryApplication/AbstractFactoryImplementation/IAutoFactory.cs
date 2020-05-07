using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApplication.AbstractFactoryImplementation
{
    /// <summary>
    /// Абстрактная фабрика по производству автомобилей.
    /// </summary>
    public interface IAutoFactory
    {
        IBody CreateBody();
        IEngine CreateEngine();
        ITank CreateTank();
    }
}
