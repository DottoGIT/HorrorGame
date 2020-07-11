using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderScript : MonoBehaviour
{
    public GameObject flashlight;
    public Animator anim;
    public AudioSource breath;
    public bool wasSpiderRevealed = false;
    public static bool canMove = true;

    public void LockPlayer()
    {
        canMove = false;
    }

    public void DisableFlashlight()
    {
        flashlight.SetActive(false);
    }

    public void EnableFlashlight()
    {
        flashlight.SetActive(true);
    }

    public void EnableGameOverScreen()
    {
        anim.SetTrigger("Start");
    }

    public void StartBreathing()
    {
        breath.Play();
    }

}
