namespace Application.Sales.Queries
{
    public interface IGetSaleDetailQuery
    {
        SaleDetailModel Execute(int saleId);
    }
}