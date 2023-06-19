using TMPro;
using UnityEngine;

namespace MVC.Scripts.Player
{
    public class PlayerView : MonoBehaviour
    {
        public TMP_Text HealthTMPText;
        public TMP_Text ScoreTMPText;

        public void UpdateView(PlayerModel _playerModel)
        {
            HealthTMPText.text = _playerModel.GetHealth().ToString();
            ScoreTMPText.text = _playerModel.GetScore().ToString();
        }
    }
}
