using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInputP1;
    public float forwardInputP1;
    public float speedP1 = 20f;
    public float turnSpeedP1 = 45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInputP1 = Input.GetAxis("Horizontal");
        forwardInputP1 = Input.GetAxis("Vertical");
        //Moves the car forward based on vetical input
        transform.Translate(Vector3.forward * Time.deltaTime * speedP1 * forwardInputP1);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeedP1 * horizontalInputP1 * Time.deltaTime);
    }
}
