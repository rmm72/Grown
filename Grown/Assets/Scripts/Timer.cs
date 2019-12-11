using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //SpriteRenderer solid;
    public static float timeLeft = 15f;

    public bool startTimer;

    public static bool time1;
    public static bool time2;
    public static bool time3;
    public GameObject LoopOne;
    public GameObject LoopTwo;
    public GameObject LoopThree;

    // Start is called before the first frame update
    void Start()
    {
        /*solid = GetComponent<SpriteRenderer>();
        Color c = solid.material.color;
        c.a = 0f;
        solid.material.color = c;
        startTimer = false;
        moveNext = false;*/
        Fade.moveLevel = true;
        time1 = false;
        time2 = false;
        time3 = false;
        LoopOne.SetActive(true);
        LoopTwo.SetActive(false);
        LoopThree.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0 && time1 == false && time2 == false && time3 == false)
        {
            //startFading();
            //LoadByIndex(2);
            Debug.Log("Item Loop 2 starting...");
            Fade.moveLevel = false;
            StartCoroutine(LoadYourAsyncScene());
            time1 = true;
            time2 = false;
            time3 = false;
            LoopOne.SetActive(true);
            LoopTwo.SetActive(true);
            LoopThree.SetActive(false);
        }
        else if (timeLeft <= 0 && time1 == false && time2 == true && time3 == false)
        {
            //startFading();
            //LoadByIndex(2);
            Debug.Log("Item Loop 3 starting...");
            StartCoroutine(LoadYourAsyncScene());
            Fade.moveLevel = false;
            time1 = false;
            time2 = true;
            time3 = true;
            LoopOne.SetActive(true);
            LoopTwo.SetActive(true);
            LoopThree.SetActive(true);
        }
        else if (timeLeft <= 0 && time1 == false && time2 == false && time3 == true)
        {
            //startFading();
            //LoadByIndex(2);
            Debug.Log("Item Loop Done.");
            StartCoroutine(LoadYourAsyncScene());
            Fade.moveLevel = false;
            LoopOne.SetActive(true);
            LoopTwo.SetActive(true);
            LoopThree.SetActive(true);
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
        //timeLeft -= Time.deltaTime;
        Debug.Log("Timer has started.");
    }

    /*public void nextScene()
    {
        SceneManager.LoadScene("03_Walking");
    }

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }*/

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("03_Walking");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
