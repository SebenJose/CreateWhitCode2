using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{

    private Vector3 StartPosition;
    private float StartWidht;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        StartWidht = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < StartPosition.x - StartWidht)
        {
            transform.position = StartPosition;
        }
    }
}
