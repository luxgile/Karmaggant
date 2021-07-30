using UnityEngine;

namespace KMG
{
    [System.Serializable]
    public class Board
    {
        [SerializeField]
        private Ring[] rings;
        [SerializeField]
        private Door[] doors;

        public Board(int rings, int ringDivisions, int tilePerRing)
        {
            this.rings = new Ring[1 + rings];
            this.rings[0] = new Ring(0, 1, 1);

            int width = ringDivisions;
            int depth = 1;

            for (int i = 0; i < rings; i++)
            {
                this.rings[i + 1] = new Ring(i + 1, width, depth);
                width *= tilePerRing;
                depth *= tilePerRing;
            }
        }

        public Tile GetTile(BoardPosition position)
        {
            return rings[position.ring].GetTile(position.position);
        }

        public Ring[] Rings => rings;
    }
}