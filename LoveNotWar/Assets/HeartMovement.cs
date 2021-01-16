using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMovement : MonoBehaviour
{

    private const float SPEED_MULTIPLIER = 10.0f;

    private float hMove = 0.0f;
    private float vMove = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + hMove * SPEED_MULTIPLIER * Time.deltaTime, transform.position.y + vMove * SPEED_MULTIPLIER * Time.deltaTime, 0.0f);
    }

    public void SetMove(float h, float v)
    {
        hMove = h;
        vMove = v;
    }

}
