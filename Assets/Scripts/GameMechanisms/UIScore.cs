using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public Text Current;   
    public Text Max;
    public Animator anim;
    public AudioSource scream;
    public Color basicColor;
    public Color redColor;

    private bool cantPlay = false;

    void Update()
    {
        Current.text = ScoreTrack.PointsCollected.ToString();
        Max.text = ScoreTrack.PointsMax.ToString();

        if (ScoreTrack.PointsCollected == 4 && cantPlay == false)
        {
            anim.SetTrigger("Start");
            cantPlay = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScoreTrack.PointsCollected++;
        }
    }

    public void Scream()
    {
        scream.Play();
    }

    public void IncreaseMaxPoints()
    {
        ScoreTrack.PointsMax = 5;
        Max.color = redColor;
    }
    public void DecreaseMaxPoints()
    {
        ScoreTrack.PointsMax = 4;
        Max.color = basicColor;
    }
    

}
