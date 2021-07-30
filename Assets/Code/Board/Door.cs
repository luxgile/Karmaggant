using UnityEngine;

namespace KMG
{
    public enum DoorType
    {
        None,
        Sun,
        Moon,
    }

    [System.Serializable]
    public class Door
    {
        [SerializeField]
        private DoorType type;
        [SerializeField]
        private Vector2Int position;
        [SerializeField]
        private int width = 5;
        [SerializeField]
        private bool isOpen;

        public Door(DoorType type, Vector2Int center)
        {
            position = center;
        }
    }
}
