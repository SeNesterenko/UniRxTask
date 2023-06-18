using System;
using UniRx;
using UnityEngine;

namespace Scenes._6._Shop
{
    public class Player : MonoBehaviour
    {
        public static Player Instance { get; private set; }

        public int Money => _moneySubject.Value;
        public IObservable<int> MoneySubject => _moneySubject;

        [SerializeField] private int _startMoney;
        private BehaviorSubject<int> _moneySubject;

        public void AddMoney(int money)
        {
            _moneySubject
                .OnNext(_moneySubject.Value + money);
        }

        public void SpendMoney(int cost)
        {
            _moneySubject
                .OnNext(_moneySubject.Value - cost);
        }
        
        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this);
            }

            Instance = this;
            DontDestroyOnLoad(this);
            _moneySubject = new BehaviorSubject<int>(_startMoney);
        }
    }
}