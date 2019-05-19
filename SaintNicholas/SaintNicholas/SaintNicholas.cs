using SaintNicholas.Builder;
using SaintNicholas.Decorator;
using SaintNicholas.Mediator;
using SaintNicholas.Post;
using SaintNicholas.Strategy;

namespace SaintNicholas.SaintNicholas
{
    public class SaintNicholas : Colleague
    {
        private static SaintNicholas _saintNicholas;
        private readonly IDecisionStrategy _decisionStrategy;
        private static readonly object Locker = new object();

        private SaintNicholas()
        {
            _decisionStrategy = new GoodBadDeedsStrategyDecision();
        }

        public static SaintNicholas GetSaintNicholas()
        {
            lock (Locker)
            {
                if (_saintNicholas == null)
                {
                    _saintNicholas = new SaintNicholas();
                }
            }

            return _saintNicholas;
        }

        public override void SendPostProduct(IProduct postProduct)
        {
            Mediator.Send(postProduct, this);
        }

        public override void ReceivePostProduct(IProduct postProduct)
        {
            var order = (Order) postProduct;
            var isChildGood = _decisionStrategy.IsGoodChild(order);
            var parcel = new ParcelDirector(order.GiftGender).MakeParcel(isChildGood, order.GiftType);

            parcel = new PostCardParcelDecorator(parcel, order.ChildName, isChildGood);
            Mediator.Send(parcel, this);
        }

        public override void SetMediator(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
