using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    private void Start()
    {
        SpiderScript.canMove = false;
        
    }
    public void UnfreezePlayer()
    {
        SpiderScript.canMove = true;
    }
}
