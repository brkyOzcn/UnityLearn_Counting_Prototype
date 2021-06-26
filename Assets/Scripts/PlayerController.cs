using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    private float horizontalInput;
    private float verticalInput;

    void Start()
    {

    }

    
    void Update()
    {
        CharacterMovement(speed);
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            CharacterMovement(10.0f);
        }
        
    }

    void CharacterMovement(float speed)
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.left * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.back * verticalInput * speed * Time.deltaTime);
    }

}
