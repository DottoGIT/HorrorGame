using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderReveal : MonoBehaviour
{
    public GameObject Spider;
    public GameObject Light;
    public GameObject Light2;
    public GameObject GameOverScene;
    public GameObject Girl;
    public CapsuleCollider DialogueCollider;
    public GameObject Door;

    void Update()
    {
        if(ScoreTrack.PointsCollected == 4)
        {
            Light.SetActive(false);
            Light2.SetActive(false);
            Spider.SetActive(true);
            GameOverScene.SetActive(true);
            Girl.SetActive(false);
            Door.SetActive(false);
            DialogueCollider.enabled = false;
        }
    }
}
