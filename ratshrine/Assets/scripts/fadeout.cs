using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeout : MonoBehaviour
{
    private Canvas canvas;
    private Animator fadeAnimator;
    private float timer = 7f;
    public GameObject dialogue;

    private void Start()
    {
        canvas = GetComponent<Canvas>();
        fadeAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex != 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
                fadeAnimator.SetBool("fade", true);
        }
        if(scene.buildIndex == 0)
            if (canvas.enabled == false)
                SceneManager.LoadScene(1);

    }

    public void SetDialogueActive()
    {
        dialogue.SetActive(true);
    }
    public void CallFade()
    {
        fadeAnimator.Play("fadeout");
    }
}