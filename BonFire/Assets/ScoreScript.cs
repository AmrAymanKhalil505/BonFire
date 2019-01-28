using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text Score;
    public float ScoreNumber;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNumber = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ScoreNumber += Time.deltaTime;
        if(ScoreNumber < 10)
        {
            Score.text = "0" + ((int)ScoreNumber).ToString();
        }
        else
        {
            Score.text = ((int)ScoreNumber).ToString();
        }
         
    }
}
