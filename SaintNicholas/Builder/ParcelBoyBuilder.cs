using SaintNicholas.Factory;
using SaintNicholas.Parcel;
using SaintNicholas.Post;

namespace SaintNicholas.Builder
{
    public class ParcelBoyBuilder : ParcelBuilder
    {
        public override void BuildGift(bool isGoodChild, GiftType giftType)
        {
            Parcel.Gift = GetFactory(isGoodChild, giftType).GetGift();
        }

        private IAbstractGiftFactory GetFactory(bool isGoodChild, GiftType giftType)
        {
            if (!isGoodChild)
            {
                return giftType == GiftType.Edible ? LemonGiftFactory : BirchGiftFactory;
            }

            return giftType == GiftType.Edible ? ChocolateGiftFactory : CarGiftFactory;
        }

        public override void BuildWrapper()
        {
            Parcel.ParcelWrapper = new ParcelWrapper {Color = Color.Blue};
        }
    }
}
