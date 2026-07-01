using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController3 : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] private InputAction jumpAction;
    [SerializeField] private float jumpForce = 10;
    [SerializeField] private float gravityModifier;
    [SerializeField] private bool isOnGround = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //playerRb.AddForce(Vector3.up * 1000);
        jumpAction.Enable();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpAction.triggered && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
