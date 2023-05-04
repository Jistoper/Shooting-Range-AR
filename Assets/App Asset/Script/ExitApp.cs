using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApp : MonoBehaviour
{
    public GameObject ExitPanel;
    private void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ExitPanel.SetActive(true);
            }
        }
    }

    public void yes()
    {
        Application.Quit();
    }

    public void no()
    {
        ExitPanel.SetActive(false);
    }
}
