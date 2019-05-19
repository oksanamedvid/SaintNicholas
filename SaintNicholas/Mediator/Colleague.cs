using SaintNicholas.Post;

namespace SaintNicholas.Mediator
{
    public abstract class Colleague
    {
        protected IMediator Mediator;

        public abstract void SendPostProduct(IProduct postProduct);
        public abstract void ReceivePostProduct(IProduct postProduct);
        public abstract void SetMediator(IMediator mediator);
    }
}
