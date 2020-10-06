using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Kaylyn McCune - 100662337
//The purpose of this script is to add functionality to the buttons on the start scene
//the buttons will transition to the play or end scene, depending on the button pressed

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to allow the play button to switch between the start scene and the play scene
    public void PlayTransition()
    {
        SceneManager.LoadScene("Play");
    }

    //function to allow the stats button to switch between the start scene and the end scene
    public void StatsTransition()
    {
        SceneManager.LoadScene("End");
    }
}
