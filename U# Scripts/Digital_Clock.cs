
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class Digital_Clock : UdonSharpBehaviour
{
    public Text textClock;
    public UnityEngine.Random rnd = new UnityEngine.Random();
    public float randomTemperature = 44f;
    private bool temperatureChanged = false;

    void Start()
    {
        textClock = GetComponent<Text>();
    }

    void Update()
    {
        DateTime time = DateTime.Now;

        // string hour = LeadingZero(time.Hour);
        // string minute = LeadingZero(time.Minute);
        // string second = LeadingZero(time.Second);

        if(time.Minute % 5 == 0 && temperatureChanged == false)
        {
            randomTemperature = UnityEngine.Random.Range(40.0f, 47.0f);
            temperatureChanged = true;
        }
        
        if(time.Minute % 5 != 0 && temperatureChanged == true)
        {
            temperatureChanged = false;
        }



        textClock.text = time.ToString() + " M3/3 " + randomTemperature.ToString("f1") + "°F";
    }

    // string LeadingZero(int n)
    // {
    //     return n.ToString().PadLeft(2, '0');
    // }
}
