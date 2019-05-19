using SaintNicholas.Parcel.Gift;

namespace SaintNicholas.Factory
{
    public class DollGiftFactory : IAbstractGiftFactory
    {
        public IGift GetGift()
        {
            return new Doll();
        }
    }
}
