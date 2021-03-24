using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public float RestartTime = 1f; 





      public void EndGame()
    {

        if(GameHasEnded == false)
        {

            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", RestartTime);
            //restart the game 

        }
       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
       

}
