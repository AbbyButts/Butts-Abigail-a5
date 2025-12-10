using UnityEngine;
using UnityEngine.Audio;

public class VictoryAudio : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip victoryAudio;

    // Update is called once per frame
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (audioSource != null && victoryAudio != null)
        {
            audioSource.PlayOneShot(victoryAudio);
        }
    }
}

