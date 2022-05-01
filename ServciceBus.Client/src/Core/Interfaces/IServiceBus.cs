namespace ServciceBus.Client.src.Core.Interfaces
{
    public interface IServiceBus<TEvent> where TEvent : class
    {
        Task PublishEvent(TEvent @event);
        Task PublishEvent(List<TEvent> @events);
    }
}
