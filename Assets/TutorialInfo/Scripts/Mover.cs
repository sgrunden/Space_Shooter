using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public static GameObject bolt;
    public Rigidbody rb = bolt.GetComponent<Rigidbody>();
    public float speed;

    private void Start()
    {
        rb.velocity = transform.forward * speed;
    }
}
