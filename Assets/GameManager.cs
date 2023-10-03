using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totalBox;
    public int finishBox;
    public int restCount = 0; // 设置冗余的箱子数量


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetStage();
        }
    }

    public void CheckFinish()
    {
        Box[] boxes = FindObjectsOfType<Box>();
        print(boxes.Length);
        if (boxes.Length > restCount + 1)
        {
            print("still boxes");
        }
        else
        {
            print("you win");
            StartCoroutine(LoadNextStage());
        }
        // if (finishBox == totalBox)
        // {
        //     if (FindObjectOfType<CountDownTime>())
        //     {
        //         if (FindObjectOfType<CountDownTime>().time >= 0)
        //         {
        //             print("you win");
        //             StartCoroutine(LoadNextStage());
        //         }
        //         else
        //         {
        //             ResetStage();
        //         }

        //     }
        //     else
        //     {
        //         print("you win");
        //         StartCoroutine(LoadNextStage());
        //     }
        // }
    }

    IEnumerator LoadNextStage()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void ResetStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
