using YStore.Managers;
using YStore.Models;

namespace YStore.Views
{
    public partial class CreateEditForm : Form
    {
        private int productId = 0;
        private readonly ProductManager _productManager;

        public CreateEditForm(ProductManager productManager)
        {
            _productManager = productManager;
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.ProductId = this.productId;
            product.ProductName = this.tbName.Text;
            product.Description = this.tbDescription.Text;

            int price;
            if (int.TryParse(this.tbPrice.Text, out price))
            {
                product.Price = price;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the price.");
                return;
            }

            int stockQuantity;
            if (int.TryParse(this.tbStockQuantity.Text, out stockQuantity))
            {
                product.StockQuantity = stockQuantity;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the stock quantity.");
                return;
            }

            if (product.ProductId == 0)
                _productManager.CreateProduct(product);
            else
                _productManager.UpdateProduct(product);

            this.DialogResult = DialogResult.OK;
        }

        private void btcCancel_Click(object sender, EventArgs e)
        {


            this.DialogResult = DialogResult.Cancel;
        }

        public void EditProduct(Product product)
        {
            this.Text = "Edit Product";
            this.label1.Text = product.ProductId.ToString();
            this.tbName.Text = product.ProductName;
            this.tbDescription.Text = product.Description;
            this.tbPrice.Text = product.Price.ToString();
            this.tbStockQuantity.Text = product.StockQuantity.ToString();

            this.productId = product.ProductId;
        }
    }
}
