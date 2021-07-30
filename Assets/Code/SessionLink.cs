using UnityEngine;

namespace KMG
{
    public class SessionLink : MonoBehaviour
    {
        private static SessionLink _instance;

        [SerializeField]
        private BoardHolder board;
        public static BoardHolder BoardManager => _instance.board;

        [SerializeField]
        private PlayersHolder players;
        public static PlayersHolder Players => _instance.players;

        private void Awake()
        {
            if (_instance == null)
                _instance = this;
        }
    }
}
