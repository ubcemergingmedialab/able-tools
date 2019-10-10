using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTestOFF : MonoBehaviour
{
    public Light light;

    void OnTriggerEnter(Collider other)
    {
        light.enabled = false;
    }

}
