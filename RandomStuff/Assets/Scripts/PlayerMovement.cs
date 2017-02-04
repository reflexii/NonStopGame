using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;
    public CharacterController cc;
    private float gravity;
    private float vSpeed;
    public float jumpSpeed;
    public float respawnTime;
    private float timer;

    private bool startTimer = false;
	
	void Update () {
        Movement();
        ApplyGravity();
        Jump();

        if (startTimer)
        {
            timer += Time.deltaTime;
        }

        if (transform.position.y < -10)
        {
            ReSpawn();
        }
    }

    public void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        cc.Move(new Vector3(horizontal, gravity, 0f) * Time.deltaTime * movementSpeed);
    }

    public void ApplyGravity()
    {
        if (!cc.isGrounded)
        {
            gravity -= 9.81f * Time.deltaTime;
        }
        
    }

    public void Jump()
    {
        if (cc.isGrounded && Input.GetButtonDown("Jump"))
        {
            gravity = 0f;
            gravity += jumpSpeed;
        }
    }

    public void ReSpawn()
    {
        startTimer = true;
        if (timer >= respawnTime)
        {
            transform.position = new Vector3(0f, 10.4f, 0f);
            Debug.Log("Respawned!");
            timer = 0f;
            startTimer = false;
            gravity = 0f;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.transform.tag == "Enemy")
        {
            Debug.Log("Collision with enemy!");
            gameObject.transform.position -= new Vector3(0f, 3f, 0f);
            ReSpawn();
        }
    }
}
