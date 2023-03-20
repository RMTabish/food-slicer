using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameSystems : MonoBehaviour
{

    public GameObject GameScoreC;
    public GameObject EndGameC;

    public Text Endscore;


    static GameSystems _syste;
    public static GameSystems Systems
    {
        get
        {
            if (_syste == null)
            {
                _syste = GameObject.FindObjectOfType<GameSystems>();

                if (_syste == null)
                {
                    GameObject container = new GameObject("GameSystems");
                    _syste = container.AddComponent<GameSystems>();
                }
            }
            return _syste;

        }

    }

    public void OnRestart()
    {
        EndGameC.SetActive(true);
        GameScoreC.SetActive(false);

        SceneManager.LoadScene(0);


    }
    public void OnknifeKill()
    {
      
        Endscore.text = Level.score.ToString();
        EndGameC.SetActive(true);
        GameScoreC.SetActive(false);
    }
    public level Level;

}

[System.Serializable]
public class level
{

    public float CurrentSpeed = 600;
    public int score=0;

    public Text scoreText;

    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = score.ToString();

        float speed = CurrentSpeed;
        if (CurrentSpeed != 1200)
        {
            if (score >= 200)
            {
                speed = 900;
                UpdateLevelSpeed(speed);
            }
            if (score >= 400)
            {
                speed = 12000;
                UpdateLevelSpeed(speed);
            }
           
        }
    }
    public void onVegetableCut()
    {
        IncreaseScore();

    }
    public void UpdateLevelSpeed(float speed)
    {
        objectSpawner spawner = GameObject.FindObjectOfType<objectSpawner>();
        Animator knifeAnimator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        if (speed == 1200)
        {
            spawner.intervalBetweenSpawn = 0.25f;
            knifeAnimator.SetFloat("speed", 2.5f);
        }

        if (speed == 900)
        {
            spawner.intervalBetweenSpawn = 0.4f;
            knifeAnimator.SetFloat("speed", 2.0f);
        }
        CurrentSpeed = speed;

        //  throw new System.NotImplementedException();
    }
}
