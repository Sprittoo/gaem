using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text : MonoBehaviour
{
    private TMP_Text thetext;
    // Start is called before the first frame update
    void Start()
    {
        thetext = GetComponent<TMP_Text>();
        thetext.text = "LinkedInasd";
    }

    // Update is called once per frame
    void Update()
    {
        thetext.text = "LinkedInasd";
        UpdateText();
    }

    void UpdateText()
    {
        thetext.text = "whatIsThisaa";
    }


}
