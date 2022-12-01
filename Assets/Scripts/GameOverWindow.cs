using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class GameOverWindow : MonoBehaviour
{
    public Text scoreText;
    public Text retryBtn;
    public Text MainMenuBtn;
    public GameObject gameObject;
    private void Awake()
    {
        scoreText = scoreText.GetComponent<Text>();

        retryBtn.GetComponent<Button_UI>().ClickFunc = () => { UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene"); };
 
        MainMenuBtn.GetComponent<Button_UI>().ClickFunc = () => { UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu"); };
        SoundManager.ButtonClickSound();
        Hide();
    }

    private void Start()
    {
        Bird.GetInstance().OnDied += Bird_OnDied;
        
    }

    private void Bird_OnDied(object sender, System.EventArgs e)
    {
        scoreText.text = Level.GetInstance().GetPipesPassedCount().ToString();
        Show();
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }
    private void Show()
    {
        gameObject.SetActive(true);
    }

}
