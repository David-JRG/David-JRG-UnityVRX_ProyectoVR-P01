using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int collectedItems = 0;

    public bool hasKey = false;

    public GameObject[] spheres;

    private void Awake()
    {
        instance = this;
    }

    public void StartMission()
    {
        spheres[0].SetActive(true);
    }

    public void CollectItem()
    {
        collectedItems++;

        UIManager.instance.ShowText(
            "Esferas recolectadas: " +
            collectedItems + "/5"
        );

        if (collectedItems < spheres.Length)
        {
            spheres[collectedItems].SetActive(true);
        }
    }
}