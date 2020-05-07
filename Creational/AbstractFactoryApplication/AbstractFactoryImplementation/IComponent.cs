[using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryApplication.AbstractFactoryImplementation
{
    /// <summary>
    /// Определяет общие свойства для всех компонентов автомобиля.
    /// Не относятся к паттерну абстрактная фабрика,
    /// нужен, чтобы уменьшить дублирование кода.
    /// </summary>
    public interface IComponent
    {
        string Name { get; }
        decimal Price { get; }
        double Weight { get; }
    }
}
