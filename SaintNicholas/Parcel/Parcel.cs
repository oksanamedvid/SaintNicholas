using System;
using SaintNicholas.Parcel.Gift;
using SaintNicholas.Post;

namespace SaintNicholas.Parcel
{
    public class Parcel : IProduct
    {
        public IGift Gift { get; set; }
        public ParcelWrapper ParcelWrapper { get; set; }
        public PostCard PostCard { get; set; }

        public override string ToString()
        {
            return GetParcel();
        }

        public virtual string GetParcel()
        {
            return $"\nGift: {Gift.GetDescription()} \t" +
                   $"Parcel Wrapper: {ParcelWrapper.Color} \t" +
                   (PostCard != null ? $"Post Card: {PostCard.Message}" : String.Empty);
        }
    }
}
