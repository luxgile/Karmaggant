using UnityEngine;

namespace KMG
{
    public class TurnHolder : MonoBehaviour
    {
        [SerializeField]
        private int turnId;

        public void AdvanceTurn()
        {
            turnId++;
            if (turnId >= SessionLink.Players.PlayerCount)
                turnId = 0;
        }

        public int TurnId => turnId;
    }
}
