using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApplication.AbstractFactoryImplementation
{
    /// <summary>
	/// Фабрика для легкового автомобиля Ока.
	/// Определяет семейство компонентов для легкового автомобиля.
	/// Содержит в себе фабричные методы.
	/// </summary>
    class CarFactory : IAutoFactory
    {
        public IBody CreateBody()
        {
            return new CarBody();
        }

        public IEngine CreateEngine()
        {
            return new CarEngine();
        }

        public ITank CreateTank()
        {
            return new CarTank();
        }
    }
}
