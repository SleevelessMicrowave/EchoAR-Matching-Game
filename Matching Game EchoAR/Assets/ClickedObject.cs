using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedObject : MonoBehaviour
{
    public GameObject lastObject;


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
                
                
                if (lastObject.tag == hit.collider.gameObject.tag && lastObject != hit.collider.gameObject)
                {
                    //Debug.Log("Destroy");
                    Destroy(lastObject);
                    Destroy(hit.collider.gameObject);
                    lastObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                }
                else
                {
                    lastObject = hit.collider.gameObject;

                }
            }
        }
    }
}