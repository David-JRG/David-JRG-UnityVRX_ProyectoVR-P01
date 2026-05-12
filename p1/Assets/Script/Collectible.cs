using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public AudioClip collectSound;

    private AudioSource audioSource;
    private MeshRenderer meshRenderer;
    private Collider col;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        meshRenderer = GetComponentInChildren<MeshRenderer>();

        col = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PLayer"))
        {
            GameManager.instance.CollectItem();

            audioSource.Stop();

            meshRenderer.enabled = false;

            col.enabled = false;

            AudioSource.PlayClipAtPoint(
                collectSound,
                transform.position
            );

            Destroy(gameObject, 0f);
        }
    }
}