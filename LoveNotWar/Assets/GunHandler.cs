using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHandler : MonoBehaviour
{

    public GameObject heartPrefab;

    int ammo = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ammo > 0)
            {
                ammo -= 1;
                GameObject newHeart = Instantiate(heartPrefab, transform.position, Quaternion.identity);
                Vector3 cameraPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 aim = new Vector3(cameraPosition.x - transform.position.x, cameraPosition.y - transform.position.y, 0.0f).normalized;
                newHeart.GetComponent<HeartMovement>().SetMove(aim.x, aim.y);
            }
        }
    }

}
