using SaintNicholas.Parcel.Gift;

namespace SaintNicholas.Factory
{
    public class LemonGiftFactory : IAbstractGiftFactory
    {
        public IGift GetGift()
        {
            return new Lemon();
        }
    }
}
