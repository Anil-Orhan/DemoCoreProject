namespace Demo.Core.Entities.DTO
{
    public class ProductReport : IDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int OrderAmounth { get; set; }
        public decimal ProductAmounth { get; set; }

    }
}