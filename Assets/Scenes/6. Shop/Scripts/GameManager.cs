using UnityEngine;

namespace Scenes._6._Shop
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private ItemModelsGenerator _itemModelsGenerator;
        [SerializeField] private ItemsSpawner _itemsSpawner;
        [SerializeField] private PlayerPresenter _playerPresenter;

        private void Start()
        {
            var itemModels = _itemModelsGenerator.GenerateItemModels();
            _itemsSpawner.Initialize(itemModels);
            _playerPresenter.Initialize();
        }
    }
}