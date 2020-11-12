using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Core;

namespace NemzetiVirusbolt.DesktopClient.Views.Components
{
    public partial class AddProductComponent : UserControl
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

       
        public AddProductComponent(IProductRepository productRepo, IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this._productRepository=productRepo;
            this._unitOfWork = unitOfWork;
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
            
        }  

    }
}
