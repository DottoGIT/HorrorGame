using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public AudioSource bite;
    public AudioSource walk;
    public AudioSource breath;
    public AudioSource feast;

    public void Quit()
    {
        Application.Quit();
    }

    public void SpiderCrawl()
    {
        walk.Play();
    }

    public void SpiderBite()
    {
        breath.enabled = false;
        feast.enabled = false;
        bite.Play();
    }
}
