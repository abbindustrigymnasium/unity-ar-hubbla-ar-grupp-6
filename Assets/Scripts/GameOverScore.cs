using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverScore : MonoBehaviour
{
    public int ScoreInt;
    public TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreInt = finishEating.CucumberInt;
        GurkaIntAdd(ScoreInt.ToString());
    }


    public void GurkaIntAdd(string num)
    {
        num = ScoreInt.ToString();
        ScoreText.text = num;
    }
}
