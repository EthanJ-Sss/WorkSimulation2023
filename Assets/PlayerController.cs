using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 movedir;
    public LayerMask detectLayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movedir = Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movedir = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movedir = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movedir = Vector2.down;
        }
        if(movedir != Vector2.zero)
        {
            if(CanMoveToDir(movedir))
            {
                Move(movedir);
            }
        }
        movedir = Vector2.zero;
    }
    bool CanMoveToDir(Vector2 dir)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 1.5f,detectLayer);
        if(!hit)
        {
            return true;
        }
        else
        {
            if(hit.collider.GetComponent<Box>()!=null)
            {
                return  hit.collider.GetComponent<Box>().CanMoveToDir(dir);
            }
            return false;
        }
    }

    void Move(Vector2 dir)
    {
         transform.Translate(dir);
    }



}
