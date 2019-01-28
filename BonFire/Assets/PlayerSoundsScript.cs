using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StepSound(){
        if(this.GetComponent<CharacterScript>().HealthDecay){
            this.GetComponents<AudioSource>()[0].Play();
        }
        else{
            this.GetComponents<AudioSource>()[1].Play();
        }
        
    }
}
