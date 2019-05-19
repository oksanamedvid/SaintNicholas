using System;
using SaintNicholas.Mediator;

namespace SaintNicholas.Post
{
    public class PostOffice : Colleague
    {
        public override void SendPostProduct(IProduct postProduct)
        {
            Mediator.Send(postProduct, this);
        }

        public override void ReceivePostProduct(IProduct postProduct)
        {
            Console.WriteLine(postProduct);
        }

        public override void SetMediator(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
