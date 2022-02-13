using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentDestroy : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
