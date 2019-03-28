using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public LayerMask mask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 20, mask))
            {
                if (hit.collider.gameObject.GetComponent<Crystal>())
                {
                    Crystal c = hit.collider.gameObject.GetComponent<Crystal>();

                    Debug.Log("hoi");

                    if (!c.activated)

                    {
                        c.activated = true;
                    }
                }
            }
        }
    }
}
