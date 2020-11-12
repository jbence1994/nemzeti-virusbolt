using System;
using System.Windows.Forms;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class StockComponent : UserControl
    {
        //private readonly IStockRepository _stockRepository;

        //private readonly IProductRepository _productRepository;
        //private readonly IUnitOfWork _unitOfWork;


        public StockComponent( /*IStockRepository stockRepository,
            IProductRepository productRepo, IUnitOfWork unitOfWork*/)
        {
            InitializeComponent();
            //this._productRepository = productRepo;
            //this._unitOfWork = unitOfWork;
            //_stockRepository = stockRepository;
        }

        private void StockComponent_Load(object sender, EventArgs e)
        {
            //dataGridViewStock.DataSource = _productRepository.GetProducts();
        }

        //private void addButton_Click(object sender, EventArgs e)
        //{
        //    String Name = nameBox.Text;
        //    double Price = double.Parse(priceBox.Text);
        //    String Unit = quantityBox.Text;
        //    String Description = descriptionBox.Text;
        //    Supplier Suppliers = new Supplier();
        //    Suppliers.Name = supplierBox.Text;

        //    Product product = new Product();
        //    product.Name = Name;
        //    product.Price = Price;
        //    product.Unit = Unit;
        //    product.Description = Description;
        //    product.Supplier = Suppliers;

        //    _productRepository.AddProduct(product);
        //    _unitOfWork.Complete();
        //}
    }
}
