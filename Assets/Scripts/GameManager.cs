using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject gameOverText;

    private bool isGameOver = false;

    void Awake()
    {
        Instance = this;
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        if (isGameOver)
            return;

        isGameOver = true;

        Debug.Log("GAME OVER!");

        if (gameOverText != null)
        {
            gameOverText.SetActive(true);
        }
        else
        {
            Debug.LogError("Game Over Text is not assigned!");
        }

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}