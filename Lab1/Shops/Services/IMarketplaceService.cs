using Shops.Entities;

namespace Shops.Services
{
    public interface IMarketplaceService
    {
        void AddBuyer(string name, decimal money);

        void AddShop(string name, string address);

        void SupplyShop(Shop shop, List<Container> containers);

        Order MakeOrder(Buyer buyer, Shop shop, ProductInfo productInfo, int count);
    }
}
