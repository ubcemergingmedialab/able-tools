using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace EML
{
    namespace FloorGen
    {

        /// <summary>
        /// Provides a cross platform way of accessing the player's room scale set up
        /// </summary>
        public class LoadXRRoomScale
        {
            
            public Vector3[] GetFloor()
            {
                if(XRDevice.GetTrackingSpaceType() == TrackingSpaceType.RoomScale)
                {

                }
                else { return null; }
                return null;
            }

        }
    }
}
