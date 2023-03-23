using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class popUpBoxScriptResume : MonoBehaviour
{
    public static Animator popUpAnimator;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is popUpBoxScript in popUpBoxScriptResume");
        popUpAnimator = GetComponent<Animator>();
    }

    public static void openPopUpResume()
    {
        Debug.Log("openPopUp from popUpBoxScriptResume");

        popUpBoxScriptResume.popUpAnimator.SetTrigger("onInteraction");
        Debug.Log("Triggered popUpAnimator from popUpBoxScriptResume");

        popUpBoxScriptResume.popUpAnimator.SetBool("isNormal", false);
    }

    public static void closePopUpResume()
    {
        Debug.Log("closePopUp from popUpBoxScriptResume");

        popUpBoxScriptResume.popUpAnimator.SetTrigger("onInteraction");
        popUpBoxScriptResume.popUpAnimator.SetBool("isNormal", true);
    }
}
