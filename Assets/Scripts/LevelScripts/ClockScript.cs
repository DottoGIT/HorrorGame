using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    public Transform clockMinuteAxis;
    public Transform clockSecondAxis;

    void Update()
    {
        clockSecondAxis.localRotation = Quaternion.Euler(0, -Time.realtimeSinceStartup * 6.25f, 0);
        clockMinuteAxis.localRotation = Quaternion.Euler(0, -Time.realtimeSinceStartup * 0.10f, 0);
    }
}
