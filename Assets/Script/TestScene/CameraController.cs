using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static CameraInput;

public class CameraController : MonoBehaviour, INewactionmapActions
{
    public Camera cam;
    public GameObject son;
    public float speed = 5;

    CameraInput _input;
    bool active;

    private void Awake()
    {
        _input = new CameraInput();

        _input.Newactionmap.Movement.started += OnMovement;
        _input.Newactionmap.Movement.canceled += OnMovement;
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Debug.Log("Registered");
        StartCoroutine(OnMovementCo(context));
    }

    IEnumerator OnMovementCo(InputAction.CallbackContext context)
    {
        while (context.started)
        {
            Vector2 vector = context.ReadValue<Vector2>();
            Vector3 vector3 = new Vector3(vector.x, vector.y, 0);
            Debug.Log(vector3);

            son.transform.Translate(vector3 * speed * Time.deltaTime);
            yield return null;
        }
    }
}
