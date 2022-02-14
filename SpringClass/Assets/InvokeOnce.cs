using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeOnce : MonoBehaviour
{
    public GameObject target;


    void Start()
    {
        Invoke("SpawnObject", 2);
    }

    void SpawnObject()
    {
        Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    }
}