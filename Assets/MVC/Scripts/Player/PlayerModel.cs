namespace MVC.Scripts.Player
{
    public class PlayerModel
    {
        private int health;
        private int score;

        public PlayerModel(int _newHealth, int _newScore)
        {
            health = _newHealth;
            score = _newScore;
        }

        #region Get

        public int GetHealth() => health;
        public int GetScore() => score;

        #endregion

        #region Set

        public void SetHealth(int _newHealth) => health = _newHealth;
        public void SetScore(int _newScore) => score = _newScore;

        #endregion
    }
}
