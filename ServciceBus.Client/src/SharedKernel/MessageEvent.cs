namespace ServciceBus.Client.src.SharedKernel
{
    public class MessageEvent
    {
        public Guid Guid { get; set; }
        public DateTime CreateAt { get; set; }

        public MessageEvent()
        {
            Guid = Guid.NewGuid();
            CreateAt = DateTime.Now;
        }
    }
}
