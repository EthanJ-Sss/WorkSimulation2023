using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDownTime : MonoBehaviour
{
    public  TextMeshProUGUI CountDownTimeNum;
    int Shi;
    int Fen;
    int miao;
    public float time ;
    void Start()
    {
        //CountDownTimeNum = this.GetComponent<TextMeshProUGUI>();
        CountDownTimeNum.text = "0:0:0";
        //print(CountDownTimeNum.text);
        StartCoroutine(enumerator());
        
    }


   
    IEnumerator enumerator()
    {      
        while (time >= 0)
        {
            Shi = (int)time / 3600;
            Fen = (int)time % 3600 / 60;
            miao = (int)time % 60;
            CountDownTimeNum.text = string.Format ("{0}:{1}:{2}",Shi,Fen ,miao );
            yield return new WaitForSeconds(1);
            time--;
        }
        
            print("you die");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        
    }
    
}