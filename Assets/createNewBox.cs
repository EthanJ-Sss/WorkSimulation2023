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
        int boxLayer = LayerMask.NameToLayer("Box");
        for (int i = 0; i < boxCount; i++)
        {
            currentBox = Instantiate(boxPrefab, spawnPoint.transform.position, Quaternion.identity);
            currentBox.layer = boxLayer;
            yield return new WaitForSeconds(1);
            yield return new WaitUntil(() => Vector3.Distance(currentBox.transform.position, spawnPoint.transform.position) > 1f );
        }
    }

    bool hasFinished(){
        return currentBox.transform.position != spawnPoint.transform.position;
    }
}


