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
        AddDistance();
        /*
        if (startTimer)
        {
            timer += Time.deltaTime;
        }
        */

        if (transform.position.y < -10)
        {
            GameGlobals.Instance.isPlayerAlive = false;
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

        if (Input.GetButtonDown("Jump") && !GameGlobals.Instance.isPlayerAlive)
        {
            Debug.Log("Restarting game");
            GameGlobals.Instance.gameStateManager.ChangeState(GameState.tStateType.Game);
            GameGlobals.Instance.score = 0;
            GameGlobals.Instance.coinsCollected = 1;
            ReSpawn();
        }
    }

    public void ReSpawn()
    {
        transform.position = new Vector3(0f, 10.4f, 0f);
        Debug.Log("Respawned!");
        timer = 0f;
        startTimer = false;
        gravity = 0f;
        GameGlobals.Instance.isPlayerAlive = true;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.transform.tag == "Enemy")
        {
            Debug.Log("Collision with enemy!");
            gameObject.transform.position -= new Vector3(0f, 3f, 0f);
            GameGlobals.Instance.isPlayerAlive = false;
            //ReSpawn();
        }
    }

    void AddDistance()
    {
        if (GameGlobals.Instance.isPlayerAlive)
        {
            GameGlobals.Instance.score += Time.deltaTime;
        }
    }
}
