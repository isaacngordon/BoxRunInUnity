using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
    public float jumpForce = 1000f;

    bool enableJump;
    float jumpTime = 0.1f;
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("maaarrrk begin");
        enableJump = true;

    }

    private void Update()
    {
        if (rb.position.y < -3f) manager.EndGame(true);
        if (Input.GetKeyUp("r")) manager.EndGame(true);
    }

    // Update is called once per frame
    // We use FixedUpdate when we are messing around with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        

        if (Input.GetKey("d")) rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("a")) rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (enableJump && Input.GetKeyDown(KeyCode.Space))
        {
            jumpTime = Time.time;
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            enableJump = false;
        }
        
        

    }
    private void OnCollisionStay(Collision collision)
    {
        enableJump = true;
    }
}
