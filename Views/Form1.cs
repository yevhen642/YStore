using System.Data;
using YStore.Managers;
using YStore.Views;

namespace YStore;

public partial class Form1 : Form
{
    private readonly ProductManager _productManager;

    public Form1(ProductManager productManager)
    {
        InitializeComponent();
        _productManager = productManager;

        ReadProducts();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
        var val = this.dataTable.SelectedRows[0].Cells[0].Value.ToString();
        if (val == null || val.Length == 0) return;

        int id = int.Parse(val);

        _productManager.RemoveProduct(id);
        ReadProducts();
    }

    private void ReadProducts()
    {
        DataTable dataTable = new();

        dataTable.Columns.Add("ProductId");
        dataTable.Columns.Add("ProductName");
        dataTable.Columns.Add("Description");
        dataTable.Columns.Add("Price");
        dataTable.Columns.Add("StockQuantity");

        var products = _productManager.GetProducts();

        foreach (var product in products)
        {
            var row = dataTable.NewRow();

            row["ProductId"] = product.ProductId.ToString();
            row["ProductName"] = product.ProductName;
            row["Description"] = product.Description;
            row["Price"] = product.Price.ToString();
            row["StockQuantity"] = product.StockQuantity.ToString();

            dataTable.Rows.Add(row);
        }

        this.dataTable.DataSource = dataTable;
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        var form = new CreateEditForm(_productManager);

        if (form.ShowDialog() == DialogResult.OK)
            ReadProducts();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        var val = this.dataTable.SelectedRows[0].Cells[0].Value.ToString();
        if (val == null || val.Length == 0) return;

        int id = int.Parse(val);

        var product = _productManager.GetProduct(id);

        CreateEditForm form = new CreateEditForm(_productManager);
        form.EditProduct(product);

        if (form.ShowDialog() == DialogResult.OK)
            ReadProducts();
    }
}
