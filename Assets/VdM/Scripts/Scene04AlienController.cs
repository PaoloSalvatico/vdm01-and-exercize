using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene04AlienController : MonoBehaviour
{
    public float speedMult;
    public float rotationMult;
    Rigidbody _rb;

    public GameObject projectilePrefab;
    public Transform spawnPoint;
    

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Mathf.Clamp01(Input.GetAxis("Vertical")) * transform.forward * speedMult;

        _rb.AddForce(movement, ForceMode.Force);


        Vector3 rotate = Input.GetAxis("Horizontal") * transform.up * rotationMult;

        _rb.AddTorque(rotate, ForceMode.Force);


        if (Input.GetButtonDown("Fire1"))
        {
            GameObject.Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
