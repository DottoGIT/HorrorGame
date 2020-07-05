using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderScript : MonoBehaviour
{
    public bool wasSpiderRevealed = false;

    void Update()
    {
        if (wasSpiderRevealed)
        {
            Debug.Log("yeet");
        }
    }
}
