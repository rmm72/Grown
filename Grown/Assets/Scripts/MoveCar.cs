using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    //public GameObject levelThree;
    //public GameObject levelFour;
    public GameObject car;

    private float positionX;

    void Start()
    {
        positionX = -7.83f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && positionX <= 4.24f)
        {
            positionX += 2f;
        }
        else if (Input.GetMouseButtonDown(1) && positionX >= -4.24f)
        {
            Debug.Log("Car moved.");
            positionX -= 2f;
        }
        car.transform.position = new Vector3(positionX, 2.02f, -476.9f);
    }
}
