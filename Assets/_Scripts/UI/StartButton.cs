using UnityEngine.UI;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // check if the game has started
    public bool gameStarted = false;

    // Reference to the button component
    private Button _button;

    private void Start()
    {
        // Get the button component
        _button = GetComponent<Button>();

        // Add a listener to the button
        _button.onClick.AddListener(StartGame);
    }
    
    private void StartGame()
    {
        // Set the gameStarted to true
        gameStarted = true;

    }
}
