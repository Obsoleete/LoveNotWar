using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Detects if the Monster is hit by the heart bullet
public class MonsterHit : MonoBehaviour
{

    public const int StartHealth = 1;
    public const int Totalhealth = 2;

    public int currentHealth;


    // Starts out by detecting the Spawn Monster Object
    void Start()
    {
        // SpawnMonster = FindObjectOfType<SpawnMonster>();

        currentHealth = StartHealth;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.collider.tag == "Heart")
        {
            currentHealth += 1;
        }
    }
}
