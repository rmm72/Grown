using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEnter : MonoBehaviour
{
    public GameObject levelOne;
    public GameObject levelTwo;
    public GameObject item_1;
    public GameObject item_2;
    public GameObject item_3;
    private float timer = 10f;

    private void Start()
    {
        item_1.SetActive(false);
        item_2.SetActive(false);
        item_3.SetActive(false);
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            levelOne.SetActive(false);
            levelTwo.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D item)
    {
        Debug.Log("inside");
        if (item.gameObject.tag == "Item_1")
        {
            Destroy(item.gameObject);
            item_1.SetActive(true);
            levelOne.SetActive(false);
            levelTwo.SetActive(true);

        }
        if (item.gameObject.tag == "Item_2")
        {
            Destroy(item.gameObject);
            item_2.SetActive(true);
            levelOne.SetActive(false);
            levelTwo.SetActive(true);
        }
        if (item.gameObject.tag == "Item_3")
        {
            Destroy(item.gameObject);
            item_3.SetActive(true);
            levelOne.SetActive(false);
            levelTwo.SetActive(true);
        }
    }
}
