using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator leftAnim;
    public Animator rightAnim;

    private bool isOpen = false;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip openSound;
    public AudioClip closeSound;
    public AudioClip lockedSound;

    public void ToggleDoor()
    {
        if (!GameManager.instance.hasKey)
        {
            UIManager.instance.ShowText(
                "La puerta está sellada."
            );
            audioSource.PlayOneShot(lockedSound);

            return;
        }

        isOpen = !isOpen;

        leftAnim.SetBool("isOpen", isOpen);
        rightAnim.SetBool("isOpen", isOpen);

        if (isOpen)
        {
            audioSource.PlayOneShot(openSound);
        }
        else
        {
            audioSource.PlayOneShot(closeSound);
        }
    }
}
