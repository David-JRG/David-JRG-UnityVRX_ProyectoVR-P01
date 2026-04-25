using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator leftAnim;   // Animator de la hoja izquierda
    public Animator rightAnim;  // Animator de la hoja derecha

    private bool isOpen = false; // Estado de la puerta

    public void ToggleDoor()
    {
        isOpen = !isOpen;

        leftAnim.SetBool("isOpen", isOpen);
        rightAnim.SetBool("isOpen", isOpen);
    }
}
