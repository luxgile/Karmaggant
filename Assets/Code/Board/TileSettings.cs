using UnityEngine;

namespace KMG
{
    public class TileSettings : ScriptableObject
    {
        [SerializeField]
        private Sprite tileIcon;
        [SerializeField]
        private string tileName;
        [SerializeField]
        private string tileDescription;
        [SerializeField]
        private Sprite tileImage;

        public Sprite TileIcon => tileIcon;
        public string TileName => tileName;
        public string TileDesc => tileDescription;
        public Sprite TileImage => tileImage;
    }
}