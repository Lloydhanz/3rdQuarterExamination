using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject[] Scenes;
    public GameObject endingScene;
    public int ActiveScene = 0;
    // Start is called before the first frame update
    void Start()
    {
        Scenes[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        SceneChanger();
    }

    public void SceneChanger()
    {
        for (int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(i == ActiveScene);  
        }
    }
    public void StartButton()
    {
        ActiveScene = 1;
    }
    public void ToIntroductionSceneButton()
    {
        ActiveScene = 2;
    }
    public void ToDecisionButton()
    {
        ActiveScene = 3;
    }
    public void ToContinuationScene_1Button()
    {
        ActiveScene = 4;
    }
    public void ToContinueGrabAndEatFoodButton()
    {
        ActiveScene = 5;
    }
    public void ToContinuationScene_2Button()
    {
        ActiveScene = 6;
    }
    public void ToBedEndingScene()
    {
        ActiveScene = 7;
    }
    public void ToContinuationToDecisionMakingNarrationButton()
    {
        ActiveScene = 8;
    }
    public void ToContinuationToDecisionMaking_2Button()
    {
        ActiveScene = 9;
    }
    public void ToContinuationToDecisionMaking_3Button()
    {
        ActiveScene = 10;
    }
    public void ToContinuationToDecisionMaking_4Button()
    {
        ActiveScene = 11;
    }
    public void ToGettingFoodAgainScene()
    {
        ActiveScene = 12;
    }
    public void ToContinuationToDecisionMaking_5Button()
    {
        ActiveScene = 13;
    }
    public void ToDecisionMaking3Button()
    {
        ActiveScene = 14;
    }
    public void ToContinueGrabAndEatFoodButton2()
    {
        ActiveScene = 15;
    }
    public void ToContinuationNarrationButton()
    {
        ActiveScene = 16;
    }
    public void ToGettingFoodAgain2()
    {
        ActiveScene = 17;
    }
    public void ToContinuationScene8()
    {
        ActiveScene = 18;
    }
    public void ToDecisionMaking4Button()
    {
        ActiveScene = 19;
    }
    public void ToEnding2Button()
    {
        ActiveScene = 20;
    }
    public void ToEnding3Button()
    {
        ActiveScene = 21;
    }
    public void ToReturnToTitleScreenButton()
    {
        ActiveScene = 0;
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}

