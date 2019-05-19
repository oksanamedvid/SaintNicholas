using SaintNicholas.Parcel;

namespace SaintNicholas.Decorator
{
    public class PostCardParcelDecorator : ParcelDecorator
    {
        public string Name { get; set; }
        public bool IsChildGood { get; set; }

        public PostCardParcelDecorator(Parcel.Parcel decoratedParcel, string name, bool isChildGood)
            : base(decoratedParcel)
        {
            Name = name;
            IsChildGood = isChildGood;
        }

        public override string GetParcel()
        {
            if (IsChildGood)
            {
                DecoratedParcel.PostCard = new PostCard
                {
                    Message = $"Hi {Name}, You are so good child. So it is my present for you"
                };
            }

            return base.GetParcel();
        }
    }
}
