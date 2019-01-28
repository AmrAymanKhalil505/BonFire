using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text GameOverText;
    bool ended;

    // Start is called before the first frame update
    void Start()
    {
        ended = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ended)
        {
            if (GameObject.FindGameObjectWithTag("Fire").GetComponent<FireScript>().intensity <= 0)
            {
                this.GetComponent<PauseMenu>().EndGame();
                GameOverText.text = "You Survived For " + this.GetComponent<ScoreScript>().Score.text + " Seconds";
                ended = true;
            }
        }
    }
}
