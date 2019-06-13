using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle_shoot : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
