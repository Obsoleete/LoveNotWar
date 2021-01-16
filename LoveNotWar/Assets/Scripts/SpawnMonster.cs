using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    private GameObject _monsterChar;
    private Transform _monsterTransform;

    private Vector3 _monsterSpawnLocation = new Vector3(0.24f, 8.2f, -4.95f);

    // Start is called before the first frame update
    private void Start()
    {
        _monsterChar = GameObject.Instantiate(Resources.Load(path:"Monster"), _monsterSpawnLocation, Quaternion.identity) as GameObject;
        _monsterTransform = _monsterChar.transform;

    }


}
