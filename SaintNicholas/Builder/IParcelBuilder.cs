using SaintNicholas.Factory;
using SaintNicholas.Post;

namespace SaintNicholas.Builder
{
    public abstract class ParcelBuilder
    {
        protected IAbstractGiftFactory LemonGiftFactory = new LemonGiftFactory();
        protected IAbstractGiftFactory BirchGiftFactory = new BirchGiftFactory();
        protected IAbstractGiftFactory CakeGiftFactory = new CakeGiftFactory();
        protected IAbstractGiftFactory ChocolateGiftFactory = new ChocolateGiftFactory();
        protected IAbstractGiftFactory DollGiftFactory = new DollGiftFactory();
        protected IAbstractGiftFactory CarGiftFactory = new CarGiftFactory();

        protected Parcel.Parcel Parcel;

        protected ParcelBuilder()
        {
            Parcel = new Parcel.Parcel();
        }

        public abstract void BuildGift(bool isGoodChild, GiftType giftType);

        public abstract void BuildWrapper();

        public Parcel.Parcel GetResult()
        {
            return Parcel;
        }
    }
}
