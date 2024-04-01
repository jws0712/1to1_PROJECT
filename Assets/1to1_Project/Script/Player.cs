using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Speed;
    Rigidbody rb;
    private Vector3 dir;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = dir * Speed;
    }
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        dir = new Vector3(moveX, rb.velocity.y, moveZ).normalized;

        //Vector3 velocity = rb.velocity;
        //velocity.x = dir.x * Speed;
        //velocity.z = dir.z * Speed;

        
        //rb.velocity = velocity;
    }
}
