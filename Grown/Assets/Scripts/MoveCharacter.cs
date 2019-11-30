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
    public bool walk1;
    public bool walk2;
    public bool walk3;

    public void Start()
    {
        positionX = -3.24f;
        walk1 = true;
        walk2 = false;
        walk3 = false;
    }
    void Update()
    {
        if (walk1 == true && walk2 == false && walk3 == false)
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
                walk1 = false;
                walk2 = true;
                walk3 = false;
                SceneManager.LoadScene("04_Driving");
                Debug.Log("Loop 1 done.");
            }
            if (Input.GetMouseButtonDown(0))
            {
                positionX += 0.75f;
            }
        } else if (walk1 == false && walk2 == true && walk3 == true)
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
                walk2 = false;
                walk3 = true;
                SceneManager.LoadScene("04_Driving");
                Debug.Log("Loop 2 done.");
            }
            if (Input.GetMouseButtonDown(0))
            {
                positionX += 1.15f;
            }
        } else if (walk1 == false && walk2 == false && walk3 == true)
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
                SceneManager.LoadScene("04_Driving");
                Debug.Log("Loop 3 done.");
            }
            if (Input.GetMouseButtonDown(0))
            {
                positionX += 1.75f;
            }
        }
       
        character.transform.position = new Vector3(positionX, -1.5f, 0f);
    }
}
