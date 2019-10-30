using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMeshCreator : MonoBehaviour
{

    MeshFilter meshF;

    // Start is called before the first frame update
    void Start()
    {
        meshF = GetComponent<MeshFilter>();
        Mesh mesh = meshF.mesh;

        Vector3[] verts = mesh.vertices;

        Vector3[] newArray = EML.FloorGen.LoadXRRoomScale.GetFloor().ToArray();

        for(int i = 0; i < 4; i++)
        {
            verts[i].x = newArray[i].x;
            verts[i].y = newArray[i].z;

        }

        mesh.vertices = verts;

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
