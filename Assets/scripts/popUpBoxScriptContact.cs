using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class popUpBoxScriptContact : MonoBehaviour
{
    public static Animator popUpAnimator;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is popUpBoxScript in popUpBoxScriptContact");
        popUpAnimator = GetComponent<Animator>();
    }

    public static void openPopUpContact()
    {
        Debug.Log("openPopUp from popUpBoxScriptContact");

        popUpBoxScriptContact.popUpAnimator.SetTrigger("onInteraction");
        Debug.Log("Triggered popUpAnimator from popUpBoxScriptContact");

        popUpBoxScriptContact.popUpAnimator.SetBool("isNormal", false);
    }

    public static void closePopUpContact()
    {
        Debug.Log("closePopUp from popUpBoxScriptContact");

        popUpBoxScriptContact.popUpAnimator.SetTrigger("onInteraction");
        popUpBoxScriptContact.popUpAnimator.SetBool("isNormal", true);
    }
}
