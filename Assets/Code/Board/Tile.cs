using UnityEngine;

namespace KMG
{
    [System.Flags]
    public enum EWall
    {
        None = 0,
        Top = 1,
        Bottom = 2,
        Right = 4,
        Left = 8,
    }

    [System.Serializable]
    public class Tile
    {
        [SerializeField]
        private TileSettings settings;
        [SerializeField]
        private EWall walls;

        public TileSettings Settings => settings;
    }
}
