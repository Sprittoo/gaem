using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class popUps : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text textlah;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void PopUp(string texty)
    {
        popUpBox.SetActive(true);
        textlah.text = texty;
        animator.SetTrigger("pop");
    }
}
