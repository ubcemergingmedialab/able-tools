using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EML
{

    /// <summary>
    /// Scales the floor of the room based on the roomscale setup. Useful if the ply area is dependant on the walkable area
    /// </summary>
    public class FloorObjectScaler : MonoBehaviour
    {
        void Start()
        {
            Vector3 target = FloorGen.LoadXRRoomScale.GetDimensions();
            target.y = 0.1f;

            transform.localScale = target;
        }

    }
}
