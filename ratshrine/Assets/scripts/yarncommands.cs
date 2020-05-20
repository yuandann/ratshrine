using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Yarn.Unity;


public class yarncommands : MonoBehaviour
{
    [YarnCommand("return")]
    public void Return()
    {
        SceneManager.LoadScene(0);
    }

    [YarnCommand("leave")]
    public void Leave()
    {
        Application.Quit();
    }
  
}
