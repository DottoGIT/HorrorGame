using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrucialController : MonoBehaviour
{
    [SerializeField] Renderer BallRenderer;
    public bool timeToDie = false;
    public float minimumDistance;
    public Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {


        if (timeToDie)
        {
            OnDestruction();
        }
    }
    
    private void OnDestruction()
    {
        ScoreTrack.PointsCollected++;
        Destroy(gameObject);
    }
}
