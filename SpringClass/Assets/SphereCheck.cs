using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCheck : MonoBehaviour
{
    public GameObject sphere;


    void Start()
    {
        Debug.Log("Active Self: " + sphere.activeSelf);
        Debug.Log("Active in Hierarchy" + sphere.activeInHierarchy);
    }
}
