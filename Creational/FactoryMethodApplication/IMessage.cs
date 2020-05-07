namespace FactoryMethodApplication
{
    /// <summary>
    /// Базовый интерфейс, который должен реализовывать любой тип Мессенеджера.
    /// Для того, чтобы добавить новый тип сообщений Мессенеджера
    /// необходимо реализовать пару интерфейсов:
    /// Imessage (этот) - для типа сообщения и IMessanager - для подключения к API мессенеджера.
    /// </summary>
    public interface IMessage
    {
        string Text { get; }
        string Target { get; }
        string Source { get; }
        void Send();
    }
}
