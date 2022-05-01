using ServciceBus.Client.src.Core.Enums;

namespace ServciceBus.Client.src.Core
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public ProductType MyProperty { get; set; }
        public string Description { get; set; } = String.Empty;    }
}
