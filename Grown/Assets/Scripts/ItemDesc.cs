using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDesc : MonoBehaviour
{
    // Attach to item GameObject

    public GameObject itemDescription;
    public GameObject itemColored;

    public bool mouseOver;

    public void Start()
    {
        itemDescription.SetActive(false);
        itemColored.SetActive(false);
        mouseOver = false;
    }

    public void Update()
    {
        if (mouseOver == true)
        {
            helloItem();
        }
        else
        {
            noItem();
        }
    }
    void OnMouseOver()
    {
        mouseOver = true;
        Debug.Log("Mouse is over GameObject.");
    }

    public void helloItem()
    {
        itemDescription.SetActive(true);
        itemColored.SetActive(true);
    }

    void OnMouseExit()
    {
        mouseOver = false;
        Debug.Log("Mouse is NOT over GameObject.");
    }

    public void noItem()
    {
        itemDescription.SetActive(false);
        itemColored.SetActive(false);
    }

}
