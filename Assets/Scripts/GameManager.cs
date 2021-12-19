using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static bool gameIsOver = false;

    public GameObject gameOverUI;
    public GameObject completeLevelUI;
    // Update is called once per frame
    void Start()
    {
        gameIsOver = false;
    }
    void Update()
    {
        if (gameIsOver)
            return;

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }
        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        gameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
