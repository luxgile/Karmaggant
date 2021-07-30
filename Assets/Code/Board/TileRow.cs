using UnityEngine;

namespace KMG
{
    [System.Serializable]
    public class TileRow
    {
        [SerializeField]
        private Tile[] tiles;

        public TileRow(int tileCount)
        {
            tiles = new Tile[tileCount];
        }

        public Tile[] Tiles => tiles;
    }
}