using SaintNicholas.Parcel.Gift;

namespace SaintNicholas.Factory
{
    public class BirchGiftFactory : IAbstractGiftFactory
    {
        public IGift GetGift()
        {
            return new Birch();
        }
    }
}
