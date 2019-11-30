using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarDrag : MonoBehaviour
{
    public Vector3 mousePosition;
    public Rigidbody2D car;
    public Vector2 direction;
    public float boostSpeed = 5f;
    public float moveSpeed = 1f;
    public float slowSpeed = 0.25f;

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

        if (car.position.x >= 7.80f)
        {
            Debug.Log("Car reached end.");
            SceneManager.LoadScene("05_Dorm");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
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
}
