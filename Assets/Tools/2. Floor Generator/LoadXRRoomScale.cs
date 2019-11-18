/*
* Summary: Backend for roomscale tools
* Use: N/A
* Tested with: Unity 2018.4
* Author: Abel Waller 2019
* \todo: expose more helper utility methods (ie. check if an object is in bounds, etc)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
#if UNITY_2017_2_OR_NEWER
using Boundary = UnityEngine.Experimental.XR.Boundary;
#elif UNITY_2017_1_OR_NEWER
using Boundary = UnityEngine.Experimental.VR.Boundary;
#endif

namespace EML
{
    namespace FloorGen
    {

        /// <summary>
        /// Provides a cross platform way of accessing the player's room scale set up
        /// </summary>
        public class LoadXRRoomScale
        {
            
            /// <summary>
            /// Returns the 4 corners of the largest convex quad in the room set up. Corners are returned clockwise
            /// </summary>
            /// <returns>List of corners</returns>
            public static List<Vector3> GetFloor()
            {
                if(XRDevice.GetTrackingSpaceType() == TrackingSpaceType.RoomScale)
                {
                    if (Boundary.configured)
                    {
                        List<Vector3> toReturn = new List<Vector3>();
                        if (Boundary.TryGetGeometry(toReturn, Boundary.Type.PlayArea))
                        {
                            return toReturn;

                        }
                        Debug.Log("No boundary returned");

                    }
                    else
                    {
                        Debug.Log("Boundary not configured");
                    }
                }
                else { return null; }
                return null;
            }
            
            /// <summary>
            /// Provides a very rough scale for accessing dimensions of the boundary. If the boundary is a perfect square, this should match. Note that the returned dimensions will always return 0 for y.
            /// </summary>
            /// <returns>Vector3 of dimensions</returns>
            public static Vector3 GetDimensions()
            {
                if (XRDevice.GetTrackingSpaceType() == TrackingSpaceType.RoomScale)
                {
                    if (Boundary.configured)
                    {
                        Vector3 toReturn = new Vector3(0, 0, 0);
                        if (Boundary.TryGetDimensions(out toReturn, Boundary.Type.PlayArea))
                        {
                            return toReturn;
                        }
                        Debug.Log("No boundary returned");

                    }
                    else
                    {
                        Debug.Log("Boundary not configured");
                    }
                }
                else { return Vector3.zero; }
                return Vector3.zero;
            }

            public static string GetVRSDK()
            {
                return XRSettings.loadedDeviceName;
            }

        }
    }
}
