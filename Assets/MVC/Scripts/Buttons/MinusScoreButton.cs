using MVC.Scripts.Player;
using UnityEngine;

namespace MVC.Scripts.Buttons
{
    public class MinusScoreButton : Button
    {
        private PlayerController playerController;
        private UnityEngine.UI.Button button;

        [SerializeField]
        private int minusAmount = 10;

        public override void Initialization(PlayerController _playerController)
        {
            playerController = _playerController;

            button = GetComponent<UnityEngine.UI.Button>();
            button.onClick.AddListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            playerController.MinusScore(minusAmount);
        }
    }
}
