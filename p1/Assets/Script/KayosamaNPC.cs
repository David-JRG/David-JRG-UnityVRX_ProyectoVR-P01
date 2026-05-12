using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KayosamaNPC : MonoBehaviour
{
    public GameObject keyObject;

    private bool missionStarted = false;
    private bool keySpawned = false;

    public void Talk()
    {
        if (!missionStarted)
        {
            missionStarted = true;

            UIManager.instance.ShowText(
                "Hace muchos años sellé mi hogar para proteger algo muy valioso. Pero la llave perdió su energía y dejó de funcionar. Necesito recolectar las 5 esferas de energía para reconstruirla."
            );

            GameManager.instance.StartMission();

            return;
        }

        if (GameManager.instance.collectedItems < 5)
        {
            UIManager.instance.ShowText(
                "Aún faltan esferas de energía."
            );
        }
        else if (!keySpawned)
        {
            keySpawned = true;

            keyObject.SetActive(true);

            UIManager.instance.ShowText(
                "Gracias por ayudarme. La llave ha recuperado su poder. Tómala... ahora podrás abrir la puerta de mi hogar."
            );
        }
    }
}