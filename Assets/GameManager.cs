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
            print("you win");
            StartCoroutine(LoadNextStage());
        }

        
    }

    IEnumerator LoadNextStage(){
        yield return new WaitForSeconds(2);
        print(finishBox);
        print(totalBox);
        finishBox = 0;
        totalBox = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void ResetStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
