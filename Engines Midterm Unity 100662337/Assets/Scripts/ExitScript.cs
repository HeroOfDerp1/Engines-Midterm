using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Kaylyn McCune - 100662337
//allows the exit button to close the game
//and the menu button to return player to the start menu

public class ExitScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ReturnToStart()
    {
        SceneManager.LoadScene("Start");
    }
}
