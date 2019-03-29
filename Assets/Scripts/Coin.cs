using UnityEngine;

public class Coin : MonoBehaviour


{
    [SerializeField] private AudioClip clip = null;

    //Add points when the player collides with the coin and play the audio
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") return;
        FindObjectOfType<ScoreManager>().Score += 1;
        AudioSource.PlayClipAtPoint(clip, transform.position);
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
}