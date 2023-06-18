using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes._6._Shop
{
    [RequireComponent(typeof(PlayerView))]
    public class PlayerPresenter : MonoBehaviour
    {
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private Button _buttonAddMoney;
        [SerializeField] private int _addedMoney = 100;

        public void Initialize()
        {
            _playerView.Display(Player.Instance.Money);
            Subscribe();
        }

        private void Subscribe()
        {
            Player.Instance.MoneySubject
                .Subscribe(_playerView.Display)
                .AddTo(this);

            _buttonAddMoney
                .OnClickAsObservable()
                .Subscribe(_ => AddMoney())
                .AddTo(this);
        }

        private void AddMoney()
        {
            Player.Instance.AddMoney(_addedMoney);
        }
    }
}