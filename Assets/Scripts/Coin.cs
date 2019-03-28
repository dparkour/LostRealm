using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip clip = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player") return;
        FindObjectOfType<ScoreManager>().Score += 1;
        AudioSource.PlayClipAtPoint(clip, transform.position);
        Destroy(gameObject);
    }
}