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
            
            public static Vector3[] GetFloor()
            {
                if(XRDevice.GetTrackingSpaceType() == TrackingSpaceType.RoomScale)
                {
                    if(XRSettings.loadedDeviceName == "Oculus")
                    {
                       // return OculusGetFloor();
                    }
                }
                else { return null; }
                return null;
            }

            public static string GetVRSDK()
            {
                return XRSettings.loadedDeviceName;
            }

            public static OVRPlugin.Vector3f[] OculusGetFloor()
            {
                OVRPlugin.BoundaryGeometry geo = OVRPlugin.GetBoundaryGeometry(OVRPlugin.BoundaryType.PlayArea);
                return geo.Points;
                //return OVRBoundary.GetGeometry(OVRBoundary.BoundaryType.PlayArea);
            }

        }
    }
}
