using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{

    public GameObject gameOverUI, gamePauseUI, gameWinUI, tap2Play;

    PlayerManager playerManager;



    private void Start()
    {
        playerManager = GameObject.FindWithTag("Player").GetComponent<PlayerManager>();
    }

    public void TapToPlayUI(bool isEnable)
    {
        tap2Play.SetActive(isEnable);
        playerManager.RoundStart();
    }


    public void GameOverUI(bool isEnable)
    {
        gameOverUI.SetActive(isEnable);
    }

    public void GameWinUI(bool isEnable)
    {
        gameWinUI.SetActive(isEnable);
    }
    public void GamePauseUI(bool isEnable)
    {
        gamePauseUI.SetActive(isEnable);
    }


    public void StartLevel()
    {


    }

    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);



    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }



}
