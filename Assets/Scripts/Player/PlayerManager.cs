using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    [SerializeReference]
    [Range(0f, 1f)]
    float drankLevel = 0f;


    PlayerAnimation playerAnimation;
    PlayerController playerController;

    UiController uiController;

    public Image DrankSlider;

    void Start()
    {
        playerAnimation = GetComponent<PlayerAnimation>();
        playerController = GetComponent<PlayerController>();
        uiController = GameObject.Find("UI Manager").GetComponent<UiController>();

    }


    void Update()
    {
        playerAnimation.WalkingState(drankLevel);
        DrankSlider.rectTransform.localScale = new Vector3(drankLevel, 1f, 1f);


        if (drankLevel >= 1)
        {
            LoseLevel();
        }
    }




    /* PLAYER Drank System */

    public void SetDankLevelUp()
    {
        if (drankLevel < 1)
            drankLevel += 0.1f;
    }

    public void SetDankLevelDown()
    {
        if (drankLevel > 0)
            drankLevel -= 0.1f;
    }



    /* LEVEL Start Win Lose Section */


    // Player Game Round Start
    public void RoundStart()
    {
        playerController.isWalkStart = true;
    }


    // Player Win The Level
    public void WinLevel()
    {
        playerController.isWalkStart = false;
        playerAnimation.Dance();
        uiController.GameWinUI(true);

    }

    // Player Lose The Level
    public void LoseLevel()
    {
        playerController.isWalkStart = false;
        playerAnimation.Fall();
        uiController.GameOverUI(true);
    }
}
