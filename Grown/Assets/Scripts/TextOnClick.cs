using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextOnClick : MonoBehaviour
{

    public GameObject fText;
    public GameObject ffText;
    public GameObject fffText;

    public bool clickedOnce;
    public bool clickedTwice;
    // Start is called before the first frame update
    void Start()
    {
        fText.SetActive(false);
        ffText.SetActive(false);
        fffText.SetActive(false);
        clickedOnce = false;
        clickedTwice = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && clickedOnce == false && clickedTwice == false)
        {
            fText.SetActive(true);
            ffText.SetActive(false);
            fffText.SetActive(false);
            clickedOnce = true;
            clickedTwice = false;
        }
        else if (Input.GetMouseButtonDown(0) && clickedOnce == true && clickedTwice == false)
        {
            fText.SetActive(true);
            ffText.SetActive(true);
            fffText.SetActive(false);
            clickedOnce = true;
            clickedTwice = true;
        }
        else if (Input.GetMouseButtonDown(0) && clickedOnce == true && clickedTwice == true)
        {
            fText.SetActive(true);
            ffText.SetActive(true);
            fffText.SetActive(true);
        }
    }
}
