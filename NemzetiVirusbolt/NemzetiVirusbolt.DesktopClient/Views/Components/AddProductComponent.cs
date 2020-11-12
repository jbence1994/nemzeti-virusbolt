using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.Core;
using NemzetiVirusbolt.Core.Models;

namespace NemzetiVirusbolt.DesktopClient.Views.Components
{
    public partial class AddProductComponent : UserControl
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        TextBox TextBox = new TextBox();

        

        public AddProductComponent(IProductRepository productRepo, IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this._productRepository=productRepo;
            this._unitOfWork = unitOfWork;
            //
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //iproduct repobol meghívni az addprpoduct nevű függvényt
            //textboxból cuccokat kizedni
            /*  IProductRepository addproduct fgv
               IUnitOfWork complete metodus*/

           // _productRepository.AddProduct();//várja a product objektumot
            _unitOfWork.Complete();

           
            String Name = nameBox.Text;
            double Price = double.Parse(priceBox.Text);
            String Unit = quantityBox.Text;
            String Description = descriptionBox.Text;           
            Supplier Suppliers = new Supplier();
            Suppliers.Name = supplierBox.Text;
            
            

            Product product = new Product();
            product.Name = Name;
            product.Price = Price;
            product.Unit = Unit;
            product.Description = Description;
            product.Supplier = Suppliers;

            _productRepository.AddProduct(product);
            _unitOfWork.Complete();
        }  

    }
}
