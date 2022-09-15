using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 10f;
    public float turnSpeed = 100f;
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputKeys();
    }
    private void FixedUpdate()
    {
        movement();
    }

    private void inputKeys()
    {
         verticalInput = Input.GetAxis("Vertical");
         horizontalInput = Input.GetAxis("Horizontal");
    }
    private void movement()
    {
        transform.Translate(Vector3.forward * speed * verticalInput*Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput*Time.deltaTime);
        
    }
}
