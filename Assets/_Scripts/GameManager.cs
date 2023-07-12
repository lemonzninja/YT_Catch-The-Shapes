using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private StartButton _startButton;

    [SerializeField] private GameObject _titlerUI;
    [SerializeField] private GameObject _gameUI;
    
   private void Start()
   {
       // Get the StartButton component
       _startButton = GameObject.Find("StartButton").GetComponent<StartButton>();
   

   }

    private void Update()
    {
         // Check if the game has started
         if (_startButton.gameStarted)
         {   
                _titlerUI.SetActive(false);
                _gameUI.SetActive(true);
         }
    }
}