using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle_shoot : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;
    public GameObject ParticleEffect;

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameObject Effect = Instantiate(ParticleEffect, transform.position, transform.rotation);
    }
}
