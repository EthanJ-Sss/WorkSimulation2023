using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countDownBoxText : MonoBehaviour
{
    public GameObject target; // 物体的Transform

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            // // 获取物体的世界坐标并转换为屏幕坐标
            // Vector3 screenPos = target.transform.position;
            // // Vector3 screenPos = Camera.main.WorldToScreenPoint(target.transform.position);
            // Debug.Log(screenPos);

            // transform.Translate(screenPos);
        }

    }
}
