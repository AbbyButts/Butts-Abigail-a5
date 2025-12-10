using UnityEngine;
using UnityEngine.Audio;

public class PegCollision : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip PegAudio;

    // Update is called once per frame
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (audioSource != null && PegAudio != null)
        {
            audioSource.PlayOneShot(PegAudio);
        }
    }
}
