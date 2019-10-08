/*
* Summary: Scales resolution in each eye according to a value between 1x and 2x - Use if high resolution is needed - note that 2x will have a performance impact.
* Use: Can be attached to any object in the scene.
* Tested with: Unity 2018.2
* Author: Abel Waller 2019
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


/// <summary>
/// Scales resolution in each eye according to a value between 1x and 2x - Use if high resolution is needed - note that 2x will have a performance impact.
/// Can be attached to any object in the scene
/// </summary>
public class XRResolutionScaler : MonoBehaviour {

	[SerializeField, Range(1.0f, 2.0f), Tooltip("Adjust the resolution in each eye. If you need higher resolution, increase to 2x and then lower to accomodate for performance dips.")]
	private float scale = 1.0f;

	// Use this for initialization
	void Awake () {
        XRSettings.eyeTextureResolutionScale = scale;
	}

}
