using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherDestroy : MonoBehaviour
{
    public GameObject other;


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}
