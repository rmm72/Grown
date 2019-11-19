using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public GameObject levelThree;
    public GameObject levelFour;
    public GameObject car;

    private float positionX;

    void Start()
    {
        positionX = 0f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && positionX <= 3.5f)
        {
            positionX += 2f;
        }
        else if (Input.GetMouseButtonDown(1) && positionX >= -3.5f)
        {
            Debug.Log("clicked");
            positionX -= 2f;
        }
        car.transform.position = new Vector3(positionX, -3f, 0f);
    }
}
