using YStore.Managers;

namespace YStore;

public partial class Form1 : Form
{
    private readonly ProductManager _productManager;

    public Form1(ProductManager productManager)
    {
        InitializeComponent();
        _productManager = productManager;
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        LoadListView();
    }

    private void LoadListView()
    {
        
    }
}
