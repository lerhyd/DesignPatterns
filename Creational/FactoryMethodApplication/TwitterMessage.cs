using System;

namespace FactoryMethodApplication
{
    /// <summary>
    /// Реализация сообщения Твиттера.
    /// Принимает сообщения длинной 140 символов.
    /// </summary>
    class TwitterMessage : MessageBase
    {
        /// <summary>
        /// Создать новый экземпляр сообщения Твиттера.
        /// </summary>
        /// <param name="text"> Текст сообщения до 140 символов. </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public TwitterMessage(string text, string source, string target) : base(text, source, target)
        {
            if (text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
        }

        /// <summary>
        /// Отправить сообщение Твиттера.
        /// </summary>
        public override void Send()
        {
            // TODO: Обращение к API Твиттера для отправки сообщения.
            // Здесь должен быть код для обращения к серверам Твиттера.
            // Для экономии времени он пропущен.
            Console.WriteLine($"Twitter: Твит от: @{Source} для @{Target}: {Text}"); ;
        }
    }
}
