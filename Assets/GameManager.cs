using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totalBox;
    public int finishBox;
    

    private void Update() {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ResetStage();
        }
    }

    public void CheckFinish()
    {
        if(finishBox == totalBox)
        {
            if (FindObjectOfType<CountDownTime>().time>=0 || SceneManager.GetActiveScene().name == "Level 01")
            {
                print("you win");
                StartCoroutine(LoadNextStage());
            }
            else
            {
                ResetStage();
            }
            
            
        }

        
    }

    IEnumerator LoadNextStage(){
        yield return new WaitForSeconds(2);
        //print(finishBox);
        //(totalBox);
        print(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void ResetStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
