using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float time = 30;
    public TextMeshProUGUI timeText;
    public AudioSource BurpSound;

    // Start is called before the first frame update
    private void Start()
    {
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {

            if(finishEating.CucumberInt >= 12)
            {
                BurpSound.Play();
                Debug.Log("BUUUURRRRPPPPP!!!");
            }

            time = 0;
            SceneManager.LoadScene("GameOverScene");
        }

        DisplayTime(time);  
    }

    private void DisplayTime( float TimeToDisplay)
    {
        if(TimeToDisplay < 0) 
        {
            TimeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(TimeToDisplay / 60);
        float seconds = Mathf.FloorToInt(TimeToDisplay % 60);   
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
        