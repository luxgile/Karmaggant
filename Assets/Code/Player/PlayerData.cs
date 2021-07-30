using UnityEngine;

namespace KMG
{
    [System.Serializable]
    public class PlayerData
    {
        [SerializeField]
        private int id;
        [SerializeField]
        private BoardPosition position;
        //Cards
        //Life

        public int ID => id;
        public BoardPosition Position => position;
    }
}
