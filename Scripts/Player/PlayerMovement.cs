using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public float GroundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump = true;
    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;
    [Header("Keybinds")]
    public KeyCode jumpKey=KeyCode.Space;
    public Transform orientation;
    
    private Alteruna.Avatar _avatar;
    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        _avatar = GetComponent<Alteruna.Avatar>();
        
        //if (!_avatar.IsMe)
            //return;
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {

        //if (!_avatar.IsMe)
            //return;
            grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        
            MyInput();

            if(grounded)
                rb.linearDamping = GroundDrag;
            else
                rb.linearDamping = 0;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if(Input.GetKey(jumpKey) && readyToJump && grounded && PlayerMonitor.istance.isMonitor == false)
        {
            readyToJump = false;
            
            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        moveDirection =orientation.forward*verticalInput + orientation.right * horizontalInput;
        if (PlayerMonitor.istance.isMonitor | ChatView.istance.isShowing) //se il player sta guardando il monitor o la chat è aperta, blocca la posizione della player
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
            rb.freezeRotation = true;
        }
        else //altrimenti sblocca la posizione e muovi il player
        {
            Debug.Log("movimento");
            rb.constraints &= ~RigidbodyConstraints.FreezePositionX;
            rb.constraints &= ~RigidbodyConstraints.FreezePositionY;
            rb.constraints &= ~RigidbodyConstraints.FreezePositionZ;
            rb.freezeRotation = true;
            
            if(grounded)
                rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);

            else if (!grounded)
                rb.AddForce(moveDirection.normalized * moveSpeed * 10f * jumpForce, ForceMode.Force);
        }
    }

    private void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump()
    {
        readyToJump = true;
    }
}
