using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Crystal crystal1;
    public Crystal crystal2;
    private Animator anim;
    [SerializeField] private GameObject uiTrigger;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(crystal1.activated && crystal2.activated)
        {
            anim.SetTrigger("OpenDoors");
            uiTrigger.SetActive(false);
        }
    }
}
