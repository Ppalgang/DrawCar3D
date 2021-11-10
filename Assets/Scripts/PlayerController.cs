using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 newVector;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        newVector = new Vector3(-3, -1, 0);
        rb.velocity = newVector * 4;
    }
}
