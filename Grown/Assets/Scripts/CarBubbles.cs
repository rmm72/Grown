using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarBubbles : MonoBehaviour
{
    public GameObject car;
    //public float dirX, dirY;
    public Rigidbody2D carGo;
    public float positionX;

    public static bool drive1;

    void Start()
    {
        //bub = GetComponent<Rigidbody2D>();
        positionX = -7.83f;
        carGo = GetComponent<Rigidbody2D>();
        car.transform.position = new Vector3(positionX, 2.02f, -476.9f);
        drive1 = false;
        Fade.moveLevel = true;
    }

    void Update()
    {
        //dirX = Input.GetAxis("Horizontal");
        //dirY = Input.GetAxis("Vertical");
        //bub.velocity = new Vector2(dirX * 10, dirY * 10);


        if (positionX >= 4.24f)
        {
            Debug.Log("Car reached end.");
            drive1 = true;
            Fade.moveLevel = false;
            SceneManager.LoadScene("05_Dorm");
            //StartCoroutine(LoadYourAsyncScene());
        }
        //car.transform.position = new Vector3(positionX, 2.02f, -476.9f);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "posBub":
                //carGo.AddForce(0, 10, 0);
                col.gameObject.SetActive(false);
                Debug.Log("Positive thought bubble gone.");
                break;
            case "negBub":
                positionX -= 2f;
                col.gameObject.SetActive(false);
                Debug.Log("Negative thought bubble gone.");
                break;
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("05_Dorm");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
