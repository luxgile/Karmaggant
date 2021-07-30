using UnityEngine;

namespace KMG
{
    public class RingComponent : MonoBehaviour
    {
        [SerializeField]
        private TileComponent prefab_Tile;
        [SerializeField]
        private AnimationCurve tileSizePerDistance;
        [SerializeField]
        private float ringOffset;
        [SerializeField]
        private Ring ring;

        private TileComponent[,] tiles;

        public void CreateRing(Ring ring, Board board)
        {
            this.ring = ring;
            tiles = new TileComponent[ring.Width, ring.Depth];
            float dist = ring.Id * ringOffset;
            Vector3 size = Vector3.one * tileSizePerDistance.Evaluate(ring.Id / (float)board.Rings.Length);
            for (int x = 0; x < ring.Width; x++)
            {
                float p = x / (float)ring.Width * 2;
                for (int z = 0; z < ring.Depth; z++)
                {
                    Vector3 position = transform.position
                        + Vector3.up * (Mathf.Cos(p * Mathf.PI) * dist / 2f)
                        + Vector3.right * (Mathf.Sin(p * Mathf.PI) * dist / 2f);
                    Vector3 dCenter = transform.position - position;
                    position += (ringOffset / ring.Depth / 2f * z * -dCenter);

                    TileComponent tc = Instantiate(prefab_Tile, position, Quaternion.LookRotation(Vector3.forward, dCenter), transform);
                    tc.transform.localScale = size;
                    tc.SetTile(ring.GetTile(x, z), new BoardPosition(x, z, ring.Id));
                    tiles[x, z] = tc;
                }
            }
        }

        public TileComponent GetTile(Vector2Int pos) => GetTile(pos.x, pos.y);
        public TileComponent GetTile(int x, int y)
        {
            return tiles[x, y];
        }

        public void UpdateRing()
        {
        }
    }
}
