using SaintNicholas.Parcel.Gift;

namespace SaintNicholas.Factory
{
    public class ChocolateGiftFactory : IAbstractGiftFactory
    {
        public IGift GetGift()
        {
            return new Chocolate();
        }
    }
}
