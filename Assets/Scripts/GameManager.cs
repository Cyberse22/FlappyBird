using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject _gameOverCanvas; // Prefab of the player to spawn

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        Time.timeScale = 1f; // Ensure the game is running at normal speed
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true); // Show the game over canvas

        Time.timeScale = 0f; // Pause the game
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reload the current scene to restart the game
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver(); // Call GameOver method when a collision occurs
    }
}
