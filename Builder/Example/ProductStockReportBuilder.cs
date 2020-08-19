using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder.Example
{
    public class ProductStockReportBuilder : IProductStockReportBuilder
    {
        private ProductStockReport _productStockReport;
        private IEnumerable<Product> _products;
        private void Clear() => _productStockReport = new ProductStockReport();

        public ProductStockReportBuilder(IEnumerable<Product> products)
        {
            _products = products;
            _productStockReport = new ProductStockReport();
        }

        public void BuildHeader()
        {
            _productStockReport.HeaderPart = $"STOCK REPORT FOR ALL THE PRODUCTS ON DATE: {DateTime.Now}\n";
        }

        public void BuildBody()
        {
            _productStockReport.BodyPart = string.Join(Environment.NewLine, _products.Select(p => $"Product name: {p.Name}, product price: {p.Price}"));
        }

        public void BuildFooter()
        {
            _productStockReport.FooterPart = $"{Environment.NewLine}Report provided by the IT_PRODUCTS company.";
        }

        public string GetReport()
        {
            var productStockReport = _productStockReport;
            Clear();
            return productStockReport.ToString();
        }
    }
}
