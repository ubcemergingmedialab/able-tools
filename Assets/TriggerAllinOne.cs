using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAllinOne : MonoBehaviour
{
    public Light light;
    private bool on = false;

    void OnTriggerEnter(Collider other)
    {
        light.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        light.enabled = false;
    }




    //{
    //    if (!on)
    //    {
    //        light.SetActive(true);
    //        on = true;
    //    }
    //    else if (on)
    //    {
    //        light.SetActive(false);
    //        on = false;
    //    }
    //}
}
