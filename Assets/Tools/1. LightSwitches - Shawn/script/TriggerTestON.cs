using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTestON : MonoBehaviour
{
    public Light light;

    void OnTriggerEnter(Collider other)
    {
        light.enabled = true;
    }

}
