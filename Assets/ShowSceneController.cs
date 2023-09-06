using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextStage());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator LoadNextStage(){
        yield return new WaitForSeconds(2);
        //print(finishBox);
        //(totalBox);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
