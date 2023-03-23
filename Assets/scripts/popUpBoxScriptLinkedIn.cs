using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class popUpBoxScriptLinkedIn : MonoBehaviour
{
    public static Animator popUpAnimator;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is popUpBoxScript in popUpBoxScriptLinkedIn");
        popUpAnimator = GetComponent<Animator>();
    }

    public static void openPopUp()
    {
        Debug.Log("openPopUp from popUpBoxScriptLnkedIn");

        popUpBoxScriptLinkedIn.popUpAnimator.SetTrigger("onInteraction");
        Debug.Log("Triggered popUpAnimator from popUpBoxScriptLnkedIn");

        popUpBoxScriptLinkedIn.popUpAnimator.SetBool("isNormal", false);


    }

    public static void closePopUp()
    {
        Debug.Log("closePopUp from popUpBoxScriptLnkedIn");
        popUpBoxScriptLinkedIn.popUpAnimator.SetTrigger("onInteraction");
        popUpBoxScriptLinkedIn.popUpAnimator.SetBool("isNormal", true);
    }
}
