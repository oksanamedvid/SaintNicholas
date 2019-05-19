using SaintNicholas.Post;

namespace SaintNicholas.Strategy
{
    interface IDecisionStrategy
    {
        bool IsGoodChild(Order order);
    }
}
