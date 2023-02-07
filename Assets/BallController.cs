using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float PushPower;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        _rigidbody.AddForce(Vector3.forward * (vertical * PushPower));
        float horizontal = Input.GetAxis("Horizontal");
        _rigidbody.AddForce(Vector3.right * (horizontal * PushPower));
    }
}
