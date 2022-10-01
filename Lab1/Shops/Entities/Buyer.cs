namespace Shops.Entities
{
    public class Buyer : EntityBase
    {
        public Buyer(Guid id, string name)
            : base(id)
        {
            Name = name;
        }

        public string Name { get; }

        public decimal Money { get; private set; }

        public void TopUp(decimal money)
        {
            if (money < 0)
            {
                // throw custom exception
            }

            Money += money;
        }
    }
}
