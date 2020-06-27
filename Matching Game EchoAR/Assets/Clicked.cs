
using UnityEngine;

public class Clicked : MonoBehaviour
{
    public float damage = 10f;
    public float range = 1000000000f;

    public string lastName = "banana";

    public Camera fpsCam;

    // Start is called before the first frame update


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
                Debug.Log("apple");
                Debug.Log(lastName);
                if (hit.collider.gameObject.name.Equals(lastName))
                {
                    Destroy(hit.collider.gameObject);
                }
                lastName = hit.collider.gameObject.name;
            }
        }
    }
}
