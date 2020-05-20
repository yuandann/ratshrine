using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class fadein : MonoBehaviour
{
    public GameObject sounds;

    // Start is called before the first frame update

    // Update is called once per frame
    [YarnCommand("fadein")]
    public void FadeIn()
    {
        GetComponent<Animator>().SetTrigger("fadein");
        sounds.SetActive(false);
    }
    
    
}
