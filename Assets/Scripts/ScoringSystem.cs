using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    public AudioSource collectSound;

    // Destroy object on collision and add a amount to the score
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        theScore += 1;
        scoreText.GetComponent<Text>().text = "COIN: " + theScore;
        Destroy(gameObject);
    }
}
