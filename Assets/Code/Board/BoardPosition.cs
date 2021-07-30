using UnityEngine;

namespace KMG
{
    [System.Serializable]
    public struct BoardPosition
    {
        public Vector2Int position;
        public int ring;

        public BoardPosition(int x, int y, int ring)
        {
            position = new Vector2Int(x, y);
            this.ring = ring;
        }

        public BoardPosition(Vector2Int position, int ring)
        {
            this.position = position;
            this.ring = ring;
        }
    }
}
