using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes._6._Shop
{
    public class ItemsSpawner : MonoBehaviour
    {
        [SerializeField] private ItemPresenter _itemPresenterPrefab;
        [SerializeField] private GridLayoutGroup _rootSpawn;

        public void Initialize(IEnumerable<ItemModel> itemModels)
        {
            foreach (var itemModel in itemModels)
            {
                var itemPresenter = Instantiate(_itemPresenterPrefab, _rootSpawn.transform);
                itemPresenter.Initialize(itemModel);
            }
        }
    }
}