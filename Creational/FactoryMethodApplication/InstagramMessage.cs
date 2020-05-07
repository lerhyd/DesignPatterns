using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FactoryMethodApplication
{
    /// <summary>
    /// Реализация сообщения Твиттера.
    /// Принимает сообщения в виде картинки.
    /// </summary>
    class InsagramMessage : MessageBase
    {
        /// <summary>
        /// Создать новый экземпляр сообщения Инстаграма.
        /// </summary>
        /// <param name="text"> Путь к файлу изображения. </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public InsagramMessage(string text, string source, string target) : base(text, source, target)
        {
            if (File.Exists(text))
            {
                var imageBytes = File.ReadAllBytes(text);
                var base64String = Convert.ToBase64String(imageBytes);
                Text = base64String;
            } else
            {
                Console.WriteLine("Файла не существует");
            }
        }

        /// <summary>
        /// Отправить сообщение Инсаграма.
        /// </summary>
        public override void Send()
        {
            // TODO: Обращение к API Инстаграма для отправки сообщения.
            // Здесь должен быть код для обращения к серверам Инстаграма.
            // Для экономии времени он пропущен.
            Console.WriteLine($"Instagram: Фото от: @{Source} для @{Target}: {Text}"); ;
        }
    }
}
