using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    private AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }


    private void Update()
    {
        if (SpiderScript.canMove && (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") !=0) && audioSrc.isPlaying == false)
        {
            audioSrc.Play();
        }
    }
        

}
