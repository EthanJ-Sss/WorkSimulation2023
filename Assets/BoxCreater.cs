using UnityEngine;
using System.Collections;

public class SpawnBoxes : MonoBehaviour
{
    public GameObject boxPrefab; // 你的Box预制体
    public int totalCanCreate = 3;

    private Collider2D lastEnterObject; // 上一个进入触发器的对象
    private bool canCreateBox = true;

    void Start()
    {
        StartCoroutine(SpawnNewBox());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D" + other.tag);
        lastEnterObject = other;
    }

    private void OnTriggerExit2D()
    {
        Debug.Log("OnTriggerExit2D");
        // Player 离开
        if (lastEnterObject.CompareTag("Player"))
        {
            StartCoroutine(SpawnNewBox());
        }
    }

    private IEnumerator SpawnNewBox()
    {
        if (totalCanCreate > 0 && canCreateBox)
        {
            canCreateBox = false;
            Debug.Log("SpawnNewBox");

            // 使用Instantiate函数生成新的Box实例
            GameObject newBox = Instantiate(boxPrefab, transform.position, Quaternion.identity);
            // 设置生成的新Box实例为空节点的子对象
            newBox.transform.parent = transform;
            totalCanCreate--;

            yield return new WaitForSeconds(1);

            canCreateBox = true;

        }
    }
}
