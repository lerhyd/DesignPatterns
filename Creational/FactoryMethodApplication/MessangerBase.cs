namespace FactoryMethodApplication
{
    /// <summary>
    /// Вспомогательный абстрактный класс для сообщения, 
    /// который помогает сократить количество кода и уменьшить его дублирование.
    /// Наследовать именно его - совсем не обязательно, достаточно реализовать интерфейс IMessager.
    /// Но он помогает немного сократить количество дублируемого кода за счёт того,
    /// что не нужно объявлять свойства и конструктор.
    /// </summary>
    public abstract class MessangerBase : IMessanger
    {
        /// <summary>
        /// Логин пользователя.
        /// </summary>
        public string UserName { get; }
        /// <summary>
        /// Пароль пользователя.
        /// </summary>

        public string Password { get; }
        /// <summary>
        /// Успешность подключения и авторизации.
        /// </summary>

        public bool Connected { get; }

        /// <summary>
        /// Создание экземпляра Мессенеджера и атворизация.
        /// </summary>
        /// <param name="name"> Имя пользователя. </param>
        /// <param name="password"> Пароль пользователя. </param>
        public MessangerBase(string name, string password)
        {
            // Не забываем проверять входные параметры перед авторизацией.
            if (!(string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(password)))
            {
                UserName = name;
                Password = password;
                Connected = Authorize();
            }
            else
            {
                Connected = false;
            }
        }

        /// <summary>
        /// Выполнить авторизацию в мессенеджере.
        /// </summary>
        /// <returns> Успешность авторизации. </returns>
        public abstract bool Authorize();

        /// <summary>
        /// Создать пакет сообщения, готового для отправки. 
        /// Это ФБАРИЧНЫЙ МЕТОД. А, если точнее, интерфейс фабричного метода - объявлен, но не реализован.
        /// </summary>
        /// <param name="text"> Текст сообщения. </param>
        /// <param name="source"> Отправитель сообщения. </param>
        /// <param name="target"> Получатель сообщения. </param>
        /// <returns> Сообщение, готовое к отправке. </returns>
        public abstract IMessage CreateMessage(string text, string source, string target);
    }
}
