using UnityEngine;

namespace Scenes._6._Shop
{
    public class ItemModel
    {
        public Sprite SpriteItem { get; }
        public int Cost { get; }

        public ItemModel(int cost, Sprite spriteItem)
        {
            Cost = cost;
            SpriteItem = spriteItem;
        }
    }
}