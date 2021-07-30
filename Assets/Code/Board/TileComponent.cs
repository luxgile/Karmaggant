using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KMG
{
    public class TileComponent : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField]
        private Tile tile;
        [SerializeField]
        private BoardPosition position;
        [SerializeField]
        private new SpriteRenderer renderer;
        [SerializeField]
        private GameObject highlight;

        public event Action TileClicked;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == 0)
                TileClicked?.Invoke();
        }

        public void SetTile(Tile tile, BoardPosition position)
        {
            this.tile = tile;
            this.position = position;
        }

        public void UpdateTile()
        {
            renderer.sprite = tile.Settings.TileImage;
        }

    }
}
