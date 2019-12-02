using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarDrag2 : MonoBehaviour
{
    public Vector3 mousePosition;
    public Rigidbody2D car;
    public Vector2 direction;
    //public float boostSpeed = 5f;
    public float moveSpeed = 1f;
    //public float slowSpeed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            car.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        }
        else
        {
            car.velocity = Vector2.zero;
        }

        if (car.position.x <= -8.0f)
        {
            Debug.Log("Car reached end.");
            //LoadByIndex(4);
            StartCoroutine(LoadYourAsyncScene());
        }
    }

    /*void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "posBub":
                car.velocity = new Vector2(direction.x * boostSpeed, direction.y * moveSpeed);
                col.gameObject.SetActive(false);
                Debug.Log("Positive thought bubble gone.");
                break;
            case "negBub":
                car.velocity = new Vector2(direction.x, direction.y);
                col.gameObject.SetActive(false);
                Debug.Log("Negative thought bubble gone.");
                break;
        }
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

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("07_Credits");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
