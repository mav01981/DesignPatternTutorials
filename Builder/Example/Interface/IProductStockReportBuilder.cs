using System.Text;

namespace Builder.Example
{
    public interface IProductStockReportBuilder
    {
        void BuildHeader();
        void BuildBody();
        void BuildFooter();
        //ProductStockReport GetReport();
    }
}
