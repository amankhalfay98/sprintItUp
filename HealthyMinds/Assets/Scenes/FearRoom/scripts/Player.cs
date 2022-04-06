using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;

    public float gravity = -5;

    float velocityY = 0;

    public Rigidbody m_Rigidbody;

    // // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A)) rb.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D)) rb.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.W)) rb.AddForce(Vector3.up);
        if (Input.GetKey(KeyCode.S)) rb.AddForce(Vector3.down);
    }
}
