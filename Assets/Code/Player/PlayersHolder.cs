using UnityEngine;

namespace KMG
{
    public class PlayersHolder : MonoBehaviour
    {
        [SerializeField]
        private PlayerComponent prefab_Player;
        [SerializeField]
        private PlayerData[] players;
        [SerializeField]
        private PlayerComponent[] playerComps;

        private void Start()
        {
            playerComps = new PlayerComponent[players.Length];

            for (int i = 0; i < players.Length; i++)
            {
                PlayerComponent pComp = Instantiate(prefab_Player, transform);
                pComp.SetPlayer(players[i]);
                playerComps[i] = pComp;
            }
        }

        public PlayerData GetPlayer(int index) => players[index];

        public int PlayerCount => players.Length;
    }
}
