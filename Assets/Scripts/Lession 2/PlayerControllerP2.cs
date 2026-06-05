using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerP2 : MonoBehaviour
{
    [SerializeField] float horizontalInput;
    [SerializeField] float speed = 10.0f;
    [SerializeField] float xRange = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject projectTilePrefab;
    [SerializeField] private Vector2 moveInput;
    [SerializeField] private InputAction moveAction;
    [SerializeField] private InputAction fireAction;
    void Start()
    {
        moveAction.Enable();
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // horizontalInput = Input.GetAxis("Horizontal");
        // transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //Keep the player in bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        moveInput = moveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);

        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        //     //Launch a projectile from the player
        //     Instantiate(projectTilePrefab, transform.position, projectTilePrefab.transform.rotation);
        // }
        if(fireAction.triggered)
        {
            //Launch a projectile from the player
            Instantiate(projectTilePrefab, transform.position, projectTilePrefab.transform.rotation);
        }
    }
}
