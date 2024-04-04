using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private Camera Camera;
    [SerializeField] private GameObject HandPos;
    private Vector3 mousePos;
    Rigidbody rb;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        HandPos = GameObject.Find("Hand").gameObject;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        mousePos = Camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rot = mousePos - HandPos.transform.position;

        float rotZ = Mathf.Atan2(rot.y, rot.x) * Mathf.Rad2Deg;

        HandPos.transform.rotation = Quaternion.Euler(45, 0, rotZ);

        PlayerDirection();
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerDirection()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        dir = new Vector3(moveX, 0, moveZ).normalized;
    }

    private void PlayerMovement()
    {
        rb.velocity = dir * Speed;
    }
}
