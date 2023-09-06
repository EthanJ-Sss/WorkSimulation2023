using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI FinishCount;
    public int finishNum = 0;
    public int totalNum = 0;


    public void GetFinishCount()
    {
        totalNum = FindObjectOfType<GameManager>().totalBox;
        FinishCount.text = "Count:"+(totalNum-finishNum).ToString();
    }
}
