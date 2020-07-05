using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderReveal : MonoBehaviour
{
    public GameObject Spider;

    void Update()
    {
        if(ScoreTrack.PointsCollected == 4)
        {
            Spider.SetActive(true);
        }
    }
}
