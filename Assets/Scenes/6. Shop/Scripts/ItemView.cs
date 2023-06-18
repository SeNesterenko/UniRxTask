using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes._6._Shop
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private Image _imageItem;
        [SerializeField] private TMP_Text _textItemCost;
        [SerializeField] private Image _imageItemBackground;

        public void Initialize(Sprite itemSprite, string itemCost)
        {
            _imageItem.sprite = itemSprite;
            _textItemCost.text = itemCost;
        }

        public void ChangeSprite(Sprite itemBackgroundSprite)
        {
            _imageItemBackground.sprite = itemBackgroundSprite;
        }
    }
}