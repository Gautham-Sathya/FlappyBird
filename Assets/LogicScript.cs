using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource ding;
    public bool gameover = false;
    public Text highscoretext;


    [ContextMenu("Increase Score")]


    public void Start()
    {

        highscoretext.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
    }
    public void addScore(int scoreIncrement)
    {
        if (gameover == false)
        {
            playerScore += scoreIncrement;
            scoreText.text = playerScore.ToString();
            ding.Play();
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        highscoretext.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
    }
    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
        highscoretext.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
       
    }
    public void gameOver()
    {
        gameover = true;
        gameOverScreen.SetActive(true);
        if(playerScore> PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", playerScore);
            highscoretext.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
            
        }
    }
}
