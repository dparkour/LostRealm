using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Crystal crystal1;
    public Crystal crystal2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(crystal1.activated && crystal2.activated)
        {
            gameObject.SetActive(false);
        }
    }
}
