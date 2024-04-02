using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Speed;
    Rigidbody rb;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        dir = new Vector3(moveX, 0, moveZ).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = dir * Speed;
    }
}
