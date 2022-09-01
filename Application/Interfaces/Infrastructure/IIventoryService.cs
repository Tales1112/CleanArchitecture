namespace Application.Interfaces.Infrastructure
{
    public interface IIventoryService
    {
        void NotifySaleOcurred(int productId, int quantity);
    }
}
