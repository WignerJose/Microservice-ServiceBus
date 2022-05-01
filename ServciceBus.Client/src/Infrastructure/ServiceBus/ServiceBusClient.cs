using ServciceBus.Client.src.Core.Interfaces;
using ServciceBus.Client.src.SharedKernel;

namespace ServciceBus.Client.src.Infrastructure.ServiceBus
{
    public class ServiceBusClient : IServiceBus<MessageEvent>
    {
        public Task PublishEvent(MessageEvent @event)
        {
            throw new NotImplementedException();
        }

        public Task PublishEvent(List<MessageEvent> events)
        {
            throw new NotImplementedException();
        }
    }
}
