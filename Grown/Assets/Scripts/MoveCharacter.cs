using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCharacter : MonoBehaviour
{
    public float positionX;
    //public GameObject levelTwo;
    //public GameObject levelThree;
    public GameObject character;
    public static bool walk1;
    public static bool walk2;
    public static bool walk3;

    public void Start()
    {
        positionX = -3.24f;
        walk1 = false;
        walk2 = false;
        walk3 = false;
        Fade.moveLevel = true;
    }
    void Update()
    {
        if (walk1 == false && walk2 == false && walk3 == false)
        {
            if (positionX > -3.24f && positionX < 4.24f)
            {
                positionX -= 0.15f * Time.deltaTime;
            }
            else if (positionX <= -3.24f)
            {
                positionX = -3.24f;
            }
            else if (positionX >= 4.24f)
            {
                //levelTwo.SetActive(false);
                //levelThree.SetActive(true);
                walk1 = true;
                walk2 = false;
                walk3 = false;
                Fade.moveLevel = false;
                //LoadByIndex(3);
                StartCoroutine(LoadYourAsyncScene());
                Debug.Log("Walking Loop 1 done.");
            }
            if (Input.GetMouseButtonDown(0))
            {
                positionX += 0.75f;
            }
        } else if (walk1 == true && walk2 == false && walk3 == false)
        {
            if (positionX > -3.24f && positionX < 4.24f)
            {
                positionX -= 0.05f * Time.deltaTime;
            }
            else if (positionX <= -3.24f)
            {
                positionX = -3.24f;
            }
            else if (positionX >= 4.24f)
            {
                //levelTwo.SetActive(false);
                //levelThree.SetActive(true); 
                walk1 = false;
                walk2 = true;
                walk3 = false;
                Fade.moveLevel = false;
                StartCoroutine(LoadYourAsyncScene());
                Debug.Log("Walking Loop 2 done.");
            }
            if (Input.GetMouseButtonDown(0))
            {
                positionX += 1.15f;
            }
        } else if (walk1 == true && walk2 == true && walk3 == false)
        {
            if (positionX > -3.24f && positionX < 4.24f)
            {
                positionX -= 0.0f * Time.deltaTime;
            }
            else if (positionX <= -3.24f)
            {
                positionX = -3.24f;
            }
            else if (positionX >= 4.24f)
            {
                walk1 = false;
                walk2 = false;
                walk3 = false;
                Fade.moveLevel = false;
                //StartCoroutine(LoadYourAsyncScene());
                Debug.Log("Walking Loop 3 done.");
            }
            if (Input.GetMouseButtonDown(0))
            {
                positionX += 1.75f;
            }
        }
       
        character.transform.position = new Vector3(positionX, -1.5f, 0f);
    }

    /*public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }*/

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("04_Driving");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
