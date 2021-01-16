using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Detects if the Monster is hit by the heart bullet
public class MonsterHit : MonoBehaviour
{

    public SpawnMonster SpawnMonster;

    // Starts out by detecting the Spawn Monster Object
    void Start()
    {
        SpawnMonster = FindObjectOfType<SpawnMonster>();
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.collider.tag == "Heart")
        {
            SpawnMonster.IncreaseHealth();
        }
    }
}
