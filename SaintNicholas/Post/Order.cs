namespace SaintNicholas.Post
{
    public class Order : IProduct
    {
        public GiftGender GiftGender { get; set; }
        public GiftType GiftType { get; set; }
        public string ChildName { get; set; }
        public int ChildAge { get; set; }
        public int GoodDeedsCount { get; set; }
        public int BadDeedsCount { get; set; }
    }
}
