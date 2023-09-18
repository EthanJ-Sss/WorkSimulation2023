using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createNewBox : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject spawnPoint;
    public int boxCount;

    private GameObject currentBox;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBoxes());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBoxes()
    {
        for (int i = 0; i < boxCount; i++)
        {
            currentBox = Instantiate(boxPrefab, spawnPoint.transform.position, Quaternion.identity);

            yield return new WaitUntil(() => currentBox.transform.position != spawnPoint.transform.position);
        }
    }
}


