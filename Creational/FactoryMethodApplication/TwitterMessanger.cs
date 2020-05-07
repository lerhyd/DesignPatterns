using System;

namespace FactoryMethodApplication
{
    /// <summary>
    /// Реализация мессенеджера Твиттера.
    /// </summary>
    class TwitterMessanger : MessangerBase
    {
        /// <summary>
        /// Создать экземпляр Мессенеджера Твиттера.
        /// </summary>
        /// <param name="name"> Логин.</param>
        /// <param name="password"> Пароль. </param>
        public TwitterMessanger(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// Авторизация пользователя в Твиттере.
        /// </summary>
        /// <returns> Успешность авторизации. </returns>
        public override bool Authorize()
        {
            // TODO: Обращение к API Твиттера для отправки сообщения.
            // Здесь должен быть код для обращения к серверам Твиттера.
            // Для экономии времени он пропущен.
            Console.WriteLine($"Авторизация в Twitter пользователя с именем {UserName} и паролем {Password}.");
            return true;
        }

        /// <summary>
        /// Создать пакет сообщения, готового для отправки в Твиттерч. 
        /// Это ФБАРИЧНЫЙ МЕТОД.
        /// </summary>
        /// <param name="text"> Текст сообщения Твиттера. </param>
        /// <param name="source"> Отправитель сообщения. </param>
        /// <param name="target"> Получатель сообщения. </param>
        /// <returns> Сообщение Твиттера, готовое к отправке. </returns>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // При необходимости здесь можно добавить дополнительные действия.
            // Например, если товарищ майор придёт и скажет, что все сообщения перед отправкой должны
            // отправляться к нему на проверку, то это можно будет добавить здесь.
            var message = new TwitterMessage(text, source, target);
            return message;
        }
    }
}
