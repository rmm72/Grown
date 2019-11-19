using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{

    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;

    void Update()
    {
        if(isBeingHeld == true)
        {
            //creates x,y,z 
            Vector3 mousePos;

            //setting mouse position 
            mousePos = Input.mousePosition;

            //convert screen point of the moust into world point
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            //Moves the gameobject
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);
        }
    }

    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //creates x,y,z 
            Vector3 mousePos;

            //setting mouse position 
            mousePos = Input.mousePosition;

            //convert screen point of the moust into world point
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            //Saves mouse position on gameobject (So it doesn't snap to the center)
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }

}
