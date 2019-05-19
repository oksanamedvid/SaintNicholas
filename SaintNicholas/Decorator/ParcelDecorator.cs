namespace SaintNicholas.Decorator
{
    public class ParcelDecorator : Parcel.Parcel
    {
        protected Parcel.Parcel DecoratedParcel { get; set; }

        public ParcelDecorator(Parcel.Parcel decoratedParcel)
        {
            DecoratedParcel = decoratedParcel;
        }

        public override string GetParcel()
        {
            return DecoratedParcel.GetParcel();
        }
    }
}
