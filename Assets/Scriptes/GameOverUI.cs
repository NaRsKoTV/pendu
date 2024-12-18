using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public GameObject canvasGO;
    public TextMeshProUGUI gameOverTmp;
    // Start is called before the first frame update
    void Start()
    {
        //canvasGO.SetActive(false);
        
    }

    public void SetGoUI(string text){
        canvasGO.SetActive(true);
        gameOverTmp.text = text;
    }

    public void SetPauseUI(){
        canvasGO.SetActive(true);
        gameOverTmp.text = "pause";
        AudioManager.Instance.PlayButtonSfx();
    }
     public void RestartGame()
    {
        AudioManager.Instance.PlayButtonSfx();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quitter()
    {
        AudioManager.Instance.PlayButtonSfx();
        Application.Quit();
    }
}
