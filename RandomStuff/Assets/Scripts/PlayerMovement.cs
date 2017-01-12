using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;
    public CharacterController cc;
    private float gravity;
    private float vSpeed;
    public float jumpSpeed;

	void Start () {
	
	}
	
	void Update () {
        Movement();
        ApplyGravity();
        ReSpawn();
        Jump();
        Debug.Log(cc.isGrounded);

        if (cc.isGrounded)
        {
                gravity = 0f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            gravity += jumpSpeed * Time.deltaTime;
        }
    }

    public void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        cc.Move(new Vector3(horizontal, gravity, 0f) * Time.deltaTime * movementSpeed);
    }

    public void ApplyGravity()
    {
        gravity -= 9.81f * Time.deltaTime;
    }

    public void Jump()
    {
        if (cc.isGrounded && Input.GetButtonDown("Jump"))
        {
            
        }
    }

    public void ReSpawn()
    {
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0f, 1.4f, 0f);
            Debug.Log("Respawned!");
        }
    }
}
