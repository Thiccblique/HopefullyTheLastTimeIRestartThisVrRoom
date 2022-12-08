using System.Collections;
using System;
using System.Globalization;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject secondHand;
    public GameObject minuteHand;
    public GameObject hourHand;
   
    // Update is called once per frame
    void Update()
    { 
        DateTime currentTime = DateTime.Now;

        float secondDegree = (currentTime.Second / 60f) * 360;
        secondHand.transform.localRotation = Quaternion.Euler(new Vector3(secondDegree, 0, 0));
        float minuteDegree = (currentTime.Minute / 60f) * 360f;
        minuteHand.transform.localRotation = Quaternion.Euler(new Vector3(minuteDegree, 0, 0));
        float hourDegree = (currentTime.Hour / 12f) * 360;
        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(hourDegree, 0, 0));
    }
}
