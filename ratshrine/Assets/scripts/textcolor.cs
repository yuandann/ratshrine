using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class textcolor : MonoBehaviour
{
    private TMP_Text text;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ColorChange()
    {
        //text.color = new Color32(200,87,229,255);
        text.color = Color.white;
    }

    public void ChangeBack()
    { 
        text.color = new Color32 (87, 229, 199,255);
    }
}
