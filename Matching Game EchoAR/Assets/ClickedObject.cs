using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedObject : MonoBehaviour
{
    public GameObject lastObject;
    //private int counter = 0;
    //private int anotherCounter = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                GameObject cover = hit.collider.gameObject;
                cover.GetComponent<Renderer>().enabled = false;
                
                if (lastObject.tag == hit.collider.gameObject.tag && lastObject != hit.collider.gameObject)
                {
                    //Debug.Log("Destroy");
                    Destroy(lastObject);
                    Destroy(hit.collider.gameObject);
                    lastObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    
                }
                /*else if (counter % 2 == 1)
                {
                    lastObject.GetComponent<Renderer>().enabled = true;
                    counter++;
                    anotherCounter++;
                }*/
                else
                {
                    /*if (anotherCounter % 2 == 1)
                    {
                        cover.GetComponent<Renderer>().enabled = true;
                    }*/
                    lastObject.GetComponent<Renderer>().enabled = true;
                    lastObject = hit.collider.gameObject;
                    
                }
            }
        }
    }
}