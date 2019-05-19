using SaintNicholas.Parcel.Gift;

namespace SaintNicholas.Factory
{
    public class CarGiftFactory : IAbstractGiftFactory
    {
        public IGift GetGift()
        {
            return new Car();
        }
    }
}
