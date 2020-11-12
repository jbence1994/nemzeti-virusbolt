﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Persistence.Repositories;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class ProductsComponent : UserControl
    {
        private readonly IProductRepository _productService;

        public ProductsComponent(IProductRepository productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private async void ButtonLoad_Click(object sender, EventArgs e)
        {
            dataGridViewCentralStock.DataSource = await GetProductDtos();
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewCentralStock.DataSource = null;
            dataGridViewCentralStock.DataSource = await GetProductDtos();
        }

        private async Task<IEnumerable<ProductDto>> GetProductDtos()
        {
            return (from product in await _productService.GetProducts()
                select ProductDto.ToDto(product)).ToList();
        }
    }
}
