using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{

    public Camera mainCam;
    
    public KeyCode right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(right))
        {
            transform.RotateAround(new Vector3(0.59f, 27.7f, 6.9f), Vector3.up, 1000 * Time.deltaTime);
        }
    }
}
