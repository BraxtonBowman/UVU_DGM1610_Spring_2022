using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponents : MonoBehaviour
{
    public GameObject otherGameObject;


    private ScoreComponent score;
    private DeathComponent death;
    private BoxCollider boxCol;


    void Awake()
    {
        score = GetComponent<ScoreComponent>();
        death = otherGameObject.GetComponent<DeathComponent>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }


    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is " + score.playerScore);
        Debug.Log("The player has died " + death.numberOfPlayerDeaths + " times");
    }
}