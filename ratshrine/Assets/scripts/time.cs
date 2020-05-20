using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class time : MonoBehaviour
{
    private TMP_Text timedisplay;
    [SerializeField] private Animator fadetrig;

    private float timer = 5f;

    private float timer2 = 5f;
    // Start is called before the first frame update
    void Start()
    {
        timedisplay = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && timedisplay.text=="2 59")
        {
            timedisplay.text = "3 00";
            timer = 5f;
        }

        
    }
}
