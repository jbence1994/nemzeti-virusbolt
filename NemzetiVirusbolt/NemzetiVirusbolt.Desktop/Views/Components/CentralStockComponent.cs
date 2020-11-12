﻿using System;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Services;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class CentralStockComponent : UserControl
    {
        private readonly IProductService _productService;

        public CentralStockComponent(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private async void CentralStockComponent_Load(object sender, EventArgs e)
        {
            dataGridViewCentralStock.DataSource = await _productService.GetProducts();
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewCentralStock.DataSource = null;
            dataGridViewCentralStock.DataSource = await _productService.GetProducts();
        }
    }
}
