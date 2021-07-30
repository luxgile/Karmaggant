using UnityEngine;

namespace KMG
{
    [System.Serializable]
    public class Ring
    {
        [SerializeField]
        private int id;
        [SerializeField]
        private TileRow[] rows;
        [SerializeField]
        private int rotation;

        public Ring(int id, int tileX, int tileY)
        {
            this.id = id;
            rows = new TileRow[tileX];
            for (int i = 0; i < tileX; i++)
                rows[i] = new TileRow(tileY);
        }
        
        public Tile GetTile(int x, int y)
        {
            return rows[x].Tiles[y];
        }
        public Tile GetTile(Vector2Int pos)
        {
            return rows[pos.x].Tiles[pos.y];
        }

        public int Id => id;
        public int Width => rows.Length;
        public int Depth => rows[0].Tiles.Length;
    }
}