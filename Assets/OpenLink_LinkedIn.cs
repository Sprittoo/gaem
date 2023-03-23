using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenLink_LinkedIn : MonoBehaviour
{

    public void OpenLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/liling-tan2/");
    }


    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }
}
