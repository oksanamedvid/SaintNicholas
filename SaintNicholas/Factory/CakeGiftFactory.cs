using SaintNicholas.Parcel.Gift;

namespace SaintNicholas.Factory
{
    public class CakeGiftFactory : IAbstractGiftFactory
    {
        public IGift GetGift()
        {
            return new Cake();
        }
    }
}
