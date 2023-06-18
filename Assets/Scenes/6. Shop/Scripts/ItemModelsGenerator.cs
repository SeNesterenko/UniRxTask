using UnityEngine;

namespace Scenes._6._Shop
{
    public class ItemModelsGenerator : MonoBehaviour
    {
        [SerializeField] private Sprite[] _itemSprites;
        [SerializeField] [Range(0, 1000)]private int _maxCost;
    
        public ItemModel[] GenerateItemModels()
        {
            var itemModels = new ItemModel[_itemSprites.Length];

            for (var i = 0; i < itemModels.Length; i++)
            {
                var itemModel = new ItemModel(Random.Range(0, _maxCost), _itemSprites[i]);
                itemModels[i] = itemModel;
            }
        
            return itemModels;
        }
    }
}