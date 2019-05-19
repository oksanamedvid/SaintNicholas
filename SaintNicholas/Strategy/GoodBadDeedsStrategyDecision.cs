using SaintNicholas.Post;

namespace SaintNicholas.Strategy
{
    public class GoodBadDeedsStrategyDecision : IDecisionStrategy
    {
        public int MaxAgeToForgiveSins = 5;

        public bool IsGoodChild(Order order)
        {
            if (order.ChildAge <= MaxAgeToForgiveSins)
            {
                return true;
            }

            return order.GoodDeedsCount >= order.BadDeedsCount;
        }
    }
}
