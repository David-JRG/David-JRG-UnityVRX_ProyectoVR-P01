using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI dialogueText;

    private void Awake()
    {
        instance = this;
    }

    public void ShowText(string message)
    {
        dialogueText.text = message;
    }
}
