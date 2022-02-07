using Tools;
namespace Model.Shop
{
<<<<<<< HEAD
    internal interface IShop
=======
    public interface IShop
>>>>>>> MyLesson2
    {
        void Buy(string id);
        string GetCost(string productID);
        void RestorePurchase();
        IReadOnlySubscriptionAction OnSuccessPurchase { get; }
        IReadOnlySubscriptionAction OnFailedPurchase { get; }
    }
}