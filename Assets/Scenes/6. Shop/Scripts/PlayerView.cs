using TMPro;
using UnityEngine;

namespace Scenes._6._Shop
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textMoney;

        public void Display(int money)
        {
            _textMoney.text = money.ToString();
        }
    }
}