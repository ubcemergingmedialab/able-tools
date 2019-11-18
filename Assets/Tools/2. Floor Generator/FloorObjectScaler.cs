/*
* Summary: Tool is for creating scaling an object to the walkable area in a room
* Use: Attach to an object to be scaled. See example scene for detailed instructions.
* Tested with: Unity 2018.4
* Author: Abel Waller 2019
*/

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
        [SerializeField, Tooltip("If true, height of the object will be set to the value of heightOverride")]
        private bool overrideHeight = false;

        [SerializeField, Tooltip("The y value of the object will be set to this value")]
        private float heightOverride = 0.1f;

        void Start()
        {
            Vector3 target = FloorGen.LoadXRRoomScale.GetDimensions();

            //If the object has a parent, we want to set its global scale, not its local scale
            if(transform.parent != null)
            {
                //Note: this can be improved with worldToLocalMatrix stuff, changing transforms is an expensive call and really isn't ideal

                Transform parent = transform.parent;
                transform.parent = null;
                SetScale(target);
                transform.parent = parent;
            }
            else
            {
                SetScale(target);
            }
        }

        /// <summary>
        /// Sets the local scale of the object to the desired vector. Y value will be overriden depending on the values specified in the editor
        /// </summary>
        /// <param name="val">Scale vector to set</param>
        private void SetScale(Vector3 val)
        {
            float yVal = overrideHeight ? heightOverride : transform.localScale.y;
            val.y = yVal;
            transform.localScale = val;
        }

    }
}
