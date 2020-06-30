using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightController : MonoBehaviour
{
    public Light spotlight;
    public static Ray ViewRay
    {
        get
        {
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }

    void Update()
    {
        spotlight.enabled = Input.GetMouseButton(0);
    }
    
}
