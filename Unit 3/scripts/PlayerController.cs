using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 10f;
    [SerializeField]private float jumpForce = 7f;
    
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    
    // Start is called before the first frame update
    void Start()
    {
        isJumping = true;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 move = transform.right * horizontalInput + transform.forward * verticalInput;
        controller.Move(move * moveSpeed * Time.deltaTime);

        // Apply gravity
        if (!controller.isGrounded)
        {
            moveDirection.y -= 9.8f * Time.deltaTime; // Adjust gravity value as needed
        }

        // Perform ground check
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, controller.height / 2 + 0.1f);
    
        // Check for jump input and apply jump force
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            moveDirection.y = jumpForce;
        }

        controller.Move(moveDirection * Time.deltaTime);
    }

}