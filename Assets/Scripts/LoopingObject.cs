using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingObject : MonoBehaviour
{
    public float maxChange = 10;
    public Vector3 changeAmount;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if the sphere traveled too far then put it back to the start
        if (Vector3.Distance(startPosition, transform.position) >= maxChange)
        {
            transform.position = startPosition;
        }
        else
        {
            transform.position += changeAmount;
        }
    }
}
