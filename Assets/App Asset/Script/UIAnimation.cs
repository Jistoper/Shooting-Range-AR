using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIAnimation : MonoBehaviour
{
    public Animator runAnima;
    public Animator runAnimaBar;
    [HideInInspector] private bool opened = false;

    public void goRunAnima()
    {
        if (!opened)
        {
            runAnima.SetTrigger("Open");
            runAnimaBar.SetTrigger("Open");
            opened = true;
        }
        else
        {
            runAnima.SetTrigger("Close");
            runAnimaBar.SetTrigger("Close");
            opened = false;
        }
    }
}
