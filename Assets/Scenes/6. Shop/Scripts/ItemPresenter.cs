using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes._6._Shop
{
    [RequireComponent(typeof(ItemView))]
    public class ItemPresenter : MonoBehaviour
    {
        [SerializeField] private ItemView _itemView;
        [SerializeField] private Button _buttonBuyItem;
        [SerializeField] private Sprite _spriteIsPurchasedItem;

        private ItemModel _itemModel;
        private readonly CompositeDisposable _subscriptions = new ();

        public void Initialize(ItemModel itemModel)
        {
            _itemModel = itemModel;
            _buttonBuyItem.interactable = false;
            Subscribe();
            _itemView.Initialize(_itemModel.SpriteItem, _itemModel.Cost.ToString());
        }

        private void Subscribe()
        {
            _buttonBuyItem
                .OnClickAsObservable()
                .Subscribe(_ => Buy())
                .AddTo(_subscriptions);
            
            Player.Instance.MoneySubject
                .Subscribe(CheckPossibilityPurchase)
                .AddTo(_subscriptions);
        }
        
        private void CheckPossibilityPurchase(int money)
        {
            _buttonBuyItem.interactable = money >= _itemModel.Cost;
        }

        private void Buy()
        {
            _subscriptions.Dispose();
            _itemView.ChangeSprite(_spriteIsPurchasedItem);
            _buttonBuyItem.onClick.RemoveAllListeners();
            Player.Instance.SpendMoney(_itemModel.Cost);
        }
    }
}