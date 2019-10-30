using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorObjectScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 target = EML.FloorGen.LoadXRRoomScale.GetDimensions();
        target.y = 0.1f;

        transform.localScale = target;
    }

}
