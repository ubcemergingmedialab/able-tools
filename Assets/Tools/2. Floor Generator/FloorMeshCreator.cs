/*
* Summary: Tool is for creating a quad of the walkable area in a room
* Use: Attach script to a quad mesh. See example scene for detailed instructions, a sample prefab is also provided.
* Tested with: Unity 2018.4
* Author: Abel Waller, Boxiu Xiao 2019
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EML
{

    /// <summary>
    /// Builds a quad on the roomscale floor. Useful for defining a visible floor area in-game
    /// </summary>
    public class FloorMeshCreator : MonoBehaviour
    {

        MeshFilter meshF;
        private Vector3[] verts;

        void Start()
        {
            meshF = GetComponent<MeshFilter>();
            Mesh mesh = meshF.mesh;

            // Fetch the original vertices
            verts = mesh.vertices;
            
            // Fetch the corners of the roomscale
            Vector3[] newArray = FloorGen.LoadXRRoomScale.GetFloor().ToArray();
            
            // Vert order is odd here as the corners in newArray are defined clockwise
            // Roomscale coordinates are defined in x z coordinates, quad is x y
            // Map roomscale corners on to the quad
            verts[1] = new Vector3(newArray[0].x, newArray[0].z);
            verts[3] = new Vector3(newArray[1].x, newArray[1].z);
            verts[0] = new Vector3(newArray[2].x, newArray[2].z);
            verts[2] = new Vector3(newArray[3].x, newArray[3].z);

            // Reassign the vertices
            mesh.vertices = verts;
            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();
        }

    }
}
