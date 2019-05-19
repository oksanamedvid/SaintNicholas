using SaintNicholas.Post;

namespace SaintNicholas.Mediator
{
    public class PostSaintNicholasMediator : IMediator
    {
        public Colleague StNicholas { get; private set; }
        public Colleague PostOffice { get; private set; }

        public PostSaintNicholasMediator()
        {
            CreateColleagues();
        }

        private void CreateColleagues()
        {
            PostOffice = new PostOffice();
            StNicholas = SaintNicholas.SaintNicholas.GetSaintNicholas();
            StNicholas.SetMediator(this);
            PostOffice.SetMediator(this);
        }

        public void Send(IProduct postProduct, Colleague colleague)
        {
            if (colleague == StNicholas)
            {
                PostOffice.ReceivePostProduct(postProduct);
            }
            else
            {
                StNicholas.ReceivePostProduct(postProduct);
            }
        }
    }
}