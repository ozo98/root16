using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCount : MonoBehaviour
{
    public int count = 0;
    public string cookieShape;
    public string color;

    private void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.tag == "Cake")
        {
            count++;
            Debug.Log("count =" + count);
        }

        if (co.gameObject.tag == cookieShape)
        {
            count++;
            Debug.Log(cookieShape + "count =" + count);
        }

        if(co.gameObject.tag == color)
        {
            count++;
        }
    }
    private void OnTriggerExit2D(Collider2D co)
    {
        if (co.gameObject.tag == "Cake")
        {
            count--;
            Debug.Log("count =" + count);
        }

        if (co.gameObject.tag == cookieShape)
        {
            count--;
            Debug.Log(cookieShape + "count =" + count);
        }

        if (co.gameObject.tag == color)
        {
            count--;
        }
    }
}
