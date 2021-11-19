using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Vector3 moveInput = Vector3.zero;

    public bool InputEnabled = true;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public Vector3 GetMoveInput() {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical");
        return InputEnabled ? moveInput : Vector3.zero;
    }

    public float GetLookInputHorizontal() {
        return InputEnabled ? Input.GetAxisRaw("Mouse X") : 0f;
    }

    public float GetLookInputVertical() {
        return InputEnabled ? Input.GetAxisRaw("Mouse Y") : 0f;
    }

    public bool GetLeftShoot() {
        return InputEnabled ? Input.GetButton("Fire1") : false;
    }

    public bool GetRightShoot() {
        return InputEnabled ? Input.GetButton("Fire2") : false;
    }

    public bool GetProjectionShift()
    {
        return InputEnabled ? Input.GetButtonDown("ProjectionShift") : false;
    }
}




































/*
[SerializeField]
    bool InputEnabled = true;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public float GetLookInputHorizontal()
    {
        return InputEnabled ? Input.GetAxisRaw("Mouse X") : 0f;
    }

    public float GetLookInputVertical()
    {
        return InputEnabled ? Input.GetAxisRaw("Mouse Y") : 0f;
    }

    public Vector3 GetMoveInput()
    {
        return InputEnabled ? new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")) : Vector3.zero;
    }

    public bool GetLeftShoot()
    {
        return InputEnabled ? Input.GetButton("Fire1") : false;
    }

    public bool GetRightShoot()
    {
        return InputEnabled ? Input.GetButton("Fire2") : false;
    }
*/
