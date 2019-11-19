using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHover : MonoBehaviour
{
    public GameObject item;
    public bool IsMouseOver;


    void Update()
    {
        if (IsMouseOver == false)
        {
            ByeItem();
        }
    }

    void OnMouseOver()
    {
        IsMouseOver = true;
    }
    void OnMouseExit()
    {
        IsMouseOver = false;
        Debug.Log("set to false");
    }


    public void ByeItem()
    {
        Destroy(item);
    }


}
