using UnityEngine;

namespace KMG
{
    public class PlayerComponent : MonoBehaviour
    {
        [SerializeField]
        private PlayerData player;

        public void SetPlayer(PlayerData player)
        {
            this.player = player;
        }

        [ContextMenu("Update")]
        public void UpdatePlayer()
        {
            transform.position = SessionLink.BoardManager.GetWorldPos(player.Position);
        }
    }
}
