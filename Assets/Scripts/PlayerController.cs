using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    private bool isOnGround;
    private Counter gameStatus;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        gameStatus = GameObject.Find("Box").GetComponent<Counter>();
    }


    void Update()
    {
        if (gameStatus.isGameOver == false)
        {
            CharacterMovement(speed);

            if (Input.GetKey(KeyCode.LeftShift) && isOnGround == true)
            {
                CharacterMovement(10.0f);
            }

            if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
            {
                playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isOnGround = false;
            }
        }
    }

    void CharacterMovement(float speed)
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.left * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.back * verticalInput * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
