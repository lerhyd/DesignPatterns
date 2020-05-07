namespace FactoryMethodApplication
{
    /// <summary>
    /// Базовый интерфейс, который должен реализовать любой Мессенеджер.
    /// Для того, чтобы добавить новый Мессенеджер, необходимо реализовать два интерфейса:
    /// IMessanager (этот) - для Мессенеджера и IMessage - для сообщения этого Мессенеджера.
    /// </summary>
    public interface IMessanger
    {
        string UserName { get; }
        string Password { get; }
        bool Connected { get; }
        IMessage CreateMessage(string text, string source, string target);
        bool Authorize();
    }
}
