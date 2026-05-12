using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public AudioClip collectSound;
    public void CollectKey()
    {
        GameManager.instance.hasKey = true;

        UIManager.instance.ShowText(
                "Has obtenido la llave energética.");

        AudioSource.PlayClipAtPoint(
              collectSound,
              transform.position
          );

        Destroy(gameObject);
    }     

}

