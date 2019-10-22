using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAllinOne : MonoBehaviour
{
    public Light light;
    public bool toggle;
    private bool on = false;

    void OnTriggerEnter(Collider other)
    {
        if (toggle)
        {
            light.enabled = !light.enabled;
        }
        else
        {
            light.enabled = !light.enabled;
        }
        }

    private void OnTriggerExit(Collider other)
    {
        if (toggle)
        {
            light.enabled = false;
        }
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
