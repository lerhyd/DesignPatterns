using System;

namespace FactoryMethodApplication
{
    /// <summary>
    /// Реализация мессенеджера Твиттера.
    /// </summary>
    class InsagramrMessanger : MessangerBase
    {
        /// <summary>
        /// Создать экземпляр Мессенеджера Инстаграма.
        /// </summary>
        /// <param name="name"> Логин.</param>
        /// <param name="password"> Пароль. </param>
        public InsagramrMessanger(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// Авторизация пользователя в Инстаграме.
        /// </summary>
        /// <returns> Успешность авторизации. </returns>
        public override bool Authorize()
        {
            // TODO: Обращение к API Инстаграма для отправки сообщения.
            // Здесь должен быть код для обращения к серверам Твиттера.
            // Для экономии времени он пропущен.
            Console.WriteLine($"Авторизация в Instagram пользователя с именем {UserName} и паролем {Password}.");
            return true;
        }

        /// <summary>
        /// Создать пакет сообщения, готового для отправки в Инстаграме. 
        /// Это ФБАРИЧНЫЙ МЕТОД.
        /// </summary>
        /// <param name="text"> Путь к файлу картинки. </param>
        /// <param name="source"> Отправитель сообщения. </param>
        /// <param name="target"> Получатель сообщения. </param>
        /// <returns> Сообщение Инстаграма, готовое к отправке. </returns>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // При необходимости здесь можно добавить дополнительные действия.
            // Например, выполнить анализ изображения для их улучшения или обучения нейронных сетей.
            var message = new InsagramMessage(text, source, target);
            return message;
        }
    }
}
