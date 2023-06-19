using UnityEngine;

namespace MVC.Scripts.Player
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerModel playerModel;
        private PlayerView playerView;

        private const int DefaultHealth = 50;
        private const int DefaultScore = 0;

        public const int MaxHealth = 100;
        public const int MinHealth = 0;

        public void Initialization()
        {
            playerModel = new PlayerModel(DefaultHealth, DefaultScore);
            playerView = GetComponent<PlayerView>();

            playerView.UpdateView(playerModel);
        }

        #region Health

        public void UpdateHealth(int _newHealth)
        {
            playerModel.SetHealth(_newHealth);
            playerView.UpdateView(playerModel);
        }

        public void PlusHealth(int _plusAmount)
        {
            var _health = playerModel.GetHealth();

            _health += _plusAmount;
            _health = Mathf.Clamp(_health, MinHealth, MaxHealth);

            playerModel.SetHealth(_health);
            playerView.UpdateView(playerModel);
        }

        public void MinusHealth(int _minusAmount)
        {
            var _health = playerModel.GetHealth();

            _health -= _minusAmount;
            _health = Mathf.Clamp(_health, MinHealth, MaxHealth);

            playerModel.SetHealth(_health);
            playerView.UpdateView(playerModel);
        }

        #endregion

        #region Score

        public void UpdateScore(int _newScore)
        {
            playerModel.SetScore(_newScore);
            playerView.UpdateView(playerModel);
        }

        public void PlusScore(int _plusAmount)
        {
            var _score = playerModel.GetScore();

            _score += _plusAmount;

            playerModel.SetScore(_score);
            playerView.UpdateView(playerModel);
        }

        public void MinusScore(int _minusAmount)
        {
            var _score = playerModel.GetScore();

            _score -= _minusAmount;

            playerModel.SetScore(_score);
            playerView.UpdateView(playerModel);
        }

        #endregion

    }
}
