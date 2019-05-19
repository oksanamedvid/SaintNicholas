using SaintNicholas.Post;

namespace SaintNicholas.Builder
{
    public class ParcelDirector
    {
        private readonly ParcelBuilder _parcelBuilder;

        public ParcelDirector(GiftGender gender)
        {
            _parcelBuilder = GetParcelBuilder(gender);
        }

        public Parcel.Parcel MakeParcel(bool isGoodChild, GiftType giftType)
        {
            _parcelBuilder.BuildGift(isGoodChild, giftType);
            _parcelBuilder.BuildWrapper();
            return _parcelBuilder.GetResult();
        }

        private static ParcelBuilder GetParcelBuilder(GiftGender gender)
        {
            if (GiftGender.Male == gender)
            {
                return new ParcelBoyBuilder();
            }

            return new ParcelGirlBuilder();
        }
    }
}

