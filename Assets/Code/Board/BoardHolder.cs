using UnityEngine;

namespace KMG
{
    public class BoardHolder : MonoBehaviour
    {
        [Header("Setup")]
        [SerializeField]
        private TileComponent prefab_Tile;
        [SerializeField]
        private RingComponent prefab_Ring;
        [SerializeField]
        private Transform p_tiles;
        [SerializeField]
        private int ringCount;
        [SerializeField]
        private int ringDivCount;
        [SerializeField]
        private float ringOffset;
        [SerializeField, Range(2, 64)]
        private int tileMultPerRing;
        [SerializeField]
        private AnimationCurve tileSizePerDistance;

        [Header("Read Only")]
        [SerializeField]
        private Board board;
        [SerializeField]
        private RingComponent[] rings;

        private void Start()
        {
            Editor_SetupBoard();
        }

        [ContextMenu("Setup Board")]
        public void Editor_SetupBoard()
        {
            board = new Board(ringCount, ringDivCount, tileMultPerRing);
            ResetBoard();
        }

        private void ResetBoard()
        {
            for (int i = 0; i < rings.Length; i++)
            {
                if (rings[i] != null)
                    DestroyImmediate(rings[i].gameObject);
            }

            rings = new RingComponent[board.Rings.Length];

            for (int i = 0; i < board.Rings.Length; i++)
            {
                Ring ring = board.Rings[i];

                RingComponent rComp = Instantiate(prefab_Ring, p_tiles);
                rComp.name = $"Ring [{i}]";
                rComp.CreateRing(ring, board);
                rings[i] = rComp;
            }
        }

        public Vector3 GetWorldPos(BoardPosition position)
        {
            return rings[position.ring].GetTile(position.position).transform.position;
        }

        public Board Board => board;
    }
}
