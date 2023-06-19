using System.Collections.Generic;
using MVC.Scripts.Buttons;
using MVC.Scripts.Player;
using UnityEngine;

namespace MVC.Scripts
{
    public class GameController : MonoBehaviour
    {
        private PlayerController playerController;
        private readonly List<Button> buttonsList = new();

        private void Awake()
        {
            playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

            var _buttonsGameObjectArray = GameObject.FindGameObjectsWithTag("Button");
            foreach (var _buttonGameObject in _buttonsGameObjectArray)
            {
                buttonsList.Add(_buttonGameObject.GetComponent<Button>());
            }

            Initialization();
        }

        private void Initialization()
        {
            playerController.Initialization();

            foreach (var _button in buttonsList)
            {
                _button.Initialization(playerController);
            }
        }
    }
}
