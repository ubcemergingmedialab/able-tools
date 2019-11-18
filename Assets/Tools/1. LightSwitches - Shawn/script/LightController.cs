using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] Light[] lights;

    [SerializeField, Tooltip("Controls behavior for entering trigger")]
    BehaviorStates enterBehavior;
    [SerializeField, Tooltip("Controls behavior for exiting trigger")]
    BehaviorStates exitBehavior;

    void OnTriggerEnter(Collider other)
    {
        if (enterBehavior.activate)
        {
            SetLights(enterBehavior.state, enterBehavior.isToggle);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exitBehavior.activate)
        {
            SetLights(exitBehavior.state, exitBehavior.isToggle);
        }
    }

    /// <summary>
    /// Sets all lights to state if toggle is false, otherwise toggles them from their currently active state
    /// </summary>
    /// <param name="state">State to set lights to</param>
    /// <param name="toggle">(Optional) Set to true to override state and instead toggle between active states</param>
    private void SetLights(bool state, bool toggle = false)
    {
        for(int i = 0; i < lights.Length; i++)
        {
            lights[i].enabled = toggle ? !lights[i].enabled : state;
        }
    }

    [System.Serializable]
    public struct BehaviorStates
    {
        [Tooltip("Controls whether this behavior should affect the lights")]
        public bool activate;
        [Tooltip("Controls what state this behavior should set lights to")]
        public bool state;
        [Tooltip("If true, override state and toggle active state on/off")]
        public bool isToggle;
    }
}
