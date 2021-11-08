using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene02PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;

    float movement;
    float rotation;
    
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        movement = Mathf.Clamp01(Input.GetAxis("Vertical"));
        rotation = Input.GetAxis("Horizontal");

        
        transform.Rotate(rotation * transform.up * rotationSpeed);
        controller.SimpleMove(movement *transform.forward *  moveSpeed);
    }
}
