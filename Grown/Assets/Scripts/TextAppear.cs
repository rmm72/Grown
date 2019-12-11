using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Mime;
using System.Diagnostics;
using UnityEngine.UI;

public class TextAppear : MonoBehaviour
{
    //private Text message;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        //message.text = "" ;
        text.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //message.text = "Isn't it too soon to leave?";
            text.SetActive(true);
        }
    }
}
