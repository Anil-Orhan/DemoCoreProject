namespace Demo.Core.Entities.Concrete
{
    public class CartLine : IEntity
    {

        public Products Product { get; set; }
        public short Quantity { get; set; }

    }
}
