using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shooting : MonoBehaviour
{
    public GameObject arCamera;

    public TextMeshProUGUI hitText;

    [HideInInspector] int hitCount;

    public void shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "dummy(Clone)")
            {
                hitCount++;
                hitText.text = hitCount.ToString();
            }
        }
    }

    public void resetHit()
    {
        hitCount = 0;
    }
}
