
namespace ClassLibrary.Model
{
    public class SaleItems
    {
        private long id;
        private int qtd;
        private double unitPrice;
        private Products product;
        private Sales sale;

        public long Id { get => id; set => id = value; }
        public int Qtd { get => qtd; set => qtd = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public Products Product { get => product; set => product = value; }
        public Sales Sale { get => sale; set => sale = value; }
    }
}
