using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMeshCreator : MonoBehaviour
{

    MeshFilter meshF;
    public Vector3[] verts;
    //public Vector3 lowerLeft, lowerRight, upperLeft, upperRight;

    // Start is called before the first frame update
    void Start()
    {
        meshF = GetComponent<MeshFilter>();
        Mesh mesh = meshF.mesh;

        verts = mesh.vertices;

       
    
        Vector3[] newArray = EML.FloorGen.LoadXRRoomScale.GetFloor().ToArray();



        verts[1] = new Vector3(newArray[0].x, newArray[0].z);
        verts[3] = new Vector3(newArray[1].x, newArray[1].z);
        verts[0] = new Vector3(newArray[2].x, newArray[2].z);
        verts[2] = new Vector3(newArray[3].x, newArray[3].z);
        
     /*   //Assign corner vectors back to vewrts array
        verts[0] = lowerRight; // --
        verts[1] = upperLeft;  // ++ 
        verts[2] = lowerLeft;  // +-
        verts[3] = upperRight; // -+
       */

        mesh.vertices = verts;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        mesh.RecalculateTangents();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
