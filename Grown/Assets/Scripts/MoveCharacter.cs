using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    private float positionX;
    public GameObject levelTwo;
    public GameObject levelThree;
    public GameObject character;
    private void Start()
    {
        positionX = -7f;
    }
    void Update()
    {
        if(positionX > -7f && positionX < 8f)
        {
            positionX -= 0.5f * Time.deltaTime;
        }
        else if (positionX <= -7f)
        {
            positionX = -7f;
        }
        else if (positionX >= 8f)
        {
            levelTwo.SetActive(false);
            levelThree.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0)){
            positionX += .5f;
        }
       
        character.transform.position = new Vector3(positionX, 0f, 0f);
    }
}
