using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //SpriteRenderer solid;
    public static float timeLeft = 15f;

    public bool startTimer;
    public bool moveNext;

    // Start is called before the first frame update
    void Start()
    {
        /*solid = GetComponent<SpriteRenderer>();
        Color c = solid.material.color;
        c.a = 0f;
        solid.material.color = c;
        startTimer = false;
        moveNext = false;*/
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            //startFading();
            SceneManager.LoadScene("03_Walking");
            if (timeLeft <= 0)
            {
                Time.timeScale = 0;
                //startFading();
                moveNext = true;
                /*if (moveNext == true)
                {
                    nextScene();
                }*/
            }
        }
            //timeLeft = 0;
        //startFading();

    }

    /*IEnumerator FadeIn()
    {
        for (float f = 0.05f; f <= 1; f+= 0.05f)
        {
            Color c = solid.material.color;
            c.a = f;
            solid.material.color = c;
            yield return new WaitForSeconds(0.05f);
            moveNext = true;
        }
    }

    public void startFading()
    {
        StartCoroutine("FadeIn");
    }*/

    void OnMouseOver()
    {
        startTimer = true;
        timeLeft -= Time.deltaTime;
        Debug.Log("Timer has started.");
    }

    /*public void nextScene()
    {
        SceneManager.LoadScene("03_Walking");
    }*/
}
