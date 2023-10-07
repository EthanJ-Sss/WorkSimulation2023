using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
   public Color finishColor;
   Color originColor;

   private void Start() 
   {
        originColor = GetComponent<SpriteRenderer>().color; 
        //totalBox = 0; 
        FindObjectOfType<GameManager>().totalBox++;
        FindObjectOfType<UIManager>().FinishCount.text = "Finished Work:" + FindObjectOfType<GameManager>().finishBox.ToString();
   }

    public bool CanMoveToDir(Vector2 dir, LayerMask detectLayer)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position + (Vector3)dir * 0.5f , dir ,  0.3f, detectLayer);
        if(!hit)
        {
            transform.Translate(dir);
            return true;
        }
        return false;
    
    }

    public bool CanMoveToDir(Vector2 dir)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position + (Vector3)dir * 0.5f , dir ,  0.3f);
        if(!hit)
        {
            transform.Translate(dir);
            return true;
        }
        return false;
    
    }


    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Target"))
        {
            FindObjectOfType<GameManager>().finishBox++;
            FindObjectOfType<GameManager>().CheckFinish();
            FindObjectOfType<UIManager>().finishNum++;
            FindObjectOfType<UIManager>().GetFinishCount();
            GetComponent<SpriteRenderer>().color = finishColor;
            Destroy(gameObject,0.5f);
        }    
    }
    private void OnTriggerExit2D(Collider2D collision) 
    {
        if (collision.CompareTag("Target"))
        {
            FindObjectOfType<GameManager>().finishBox--;
            GetComponent<SpriteRenderer>().color = originColor;
        }    
    }
}
