using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApplication.AbstractFactoryImplementation
{
	/// <summary>
	/// Фабрика по производству Камазов.
	/// Определяет семейство грузовых автомобилей.
	/// Содержит в себе фабричные методы.
	/// </summary>
	public class TruckFactory : IAutoFactory
	{
		public IBody CreateBody()
		{
			return new TruckBody();
		}

		public IEngine CreateEngine()
		{
			return new TruckEngine();
		}

		public ITank CreateTank()
		{
			return new TruckTank();
		}
	}
}
