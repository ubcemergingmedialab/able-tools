using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
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
}
