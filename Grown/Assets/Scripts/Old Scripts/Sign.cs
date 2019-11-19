using System.Diagnostics;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Sign : MonoBehaviour
{
    private Text message;
    private bool notHit;
    
    void Start()
    {
      
        message = GameObject.Find("Tip").GetComponent<Text>();
        message.color = Color.white;
        message.text = "The lights are calling me.";
        notHit =true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && notHit)
        {
            message.text = "Maybe I can double jump across...";

        }
        
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            message.text = "...";
        }
    }
}
