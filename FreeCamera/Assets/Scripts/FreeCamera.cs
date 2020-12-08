using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    [Header("FreeCamera Settings")]
    [Tooltip("Acctual camera speed")]
    public float CameraSpeed = 2;
    [Tooltip("How much faster the camera should move after pressing the selected button")]
    public float CameraSpeedMultiplier = 2;
    [Tooltip("Maximum camera speed")]
    public float MaxCameraSpeed = 10;
    [Tooltip("Mouse sensitivity")]
    public float MouseSensitivity = 5;

    private SimpleCameraInput _cameraInput;

    //Keyboard input
    private float _xInput;
    private float _yInput;
    private float _zInput;
    private bool _isSpeedUp;

    //Mouse input
    private float _mouseXInput;
    private float _mouseYInput;
    private float _rotationX, _rotationY;

    private void Start()
    {
        _cameraInput = GetComponent<SimpleCameraInput>();
    }

    private void Update()
    {
        CheckKeyboardInput();
        CheckMouseInput();
    }

    private void LateUpdate()
    {
        MouseMovement();
        CameraMovement();
    }

    private void CheckKeyboardInput()
    {
        _xInput = _cameraInput.GetAxis(_cameraInput.xAxis);
        _yInput = _cameraInput.GetAxis(_cameraInput.yAxis);
        _zInput = _cameraInput.GetAxis(_cameraInput.zAxis);
        _isSpeedUp = Input.GetKey(_cameraInput.SpeedKey);
    }

    private void CameraMovement()
    {
        if(!_isSpeedUp)
        {
            transform.position += transform.forward * _xInput * CameraSpeed * Time.fixedDeltaTime;
            transform.position += transform.right * _yInput * CameraSpeed * Time.fixedDeltaTime;
            transform.position += transform.up * _zInput * CameraSpeed * Time.fixedDeltaTime;
        }
        else
        {
            transform.position += transform.forward * _xInput * CameraSpeed * CameraSpeedMultiplier * Time.fixedDeltaTime;
            transform.position += transform.right * _yInput * CameraSpeed * CameraSpeedMultiplier * Time.fixedDeltaTime;
            transform.position += transform.up * _zInput * CameraSpeed * CameraSpeedMultiplier * Time.fixedDeltaTime;
        }


    }

    private void CheckMouseInput()
    {
        _mouseXInput = Input.GetAxis("Mouse X");
        _mouseYInput = Input.GetAxis("Mouse Y");
    }

    private void MouseMovement()
    {
        _rotationX += _mouseXInput * MouseSensitivity * Time.fixedDeltaTime;
        _rotationY += _mouseYInput * MouseSensitivity * Time.fixedDeltaTime;

        transform.localRotation = Quaternion.AngleAxis(_rotationX, Vector3.up);
        transform.localRotation *= Quaternion.AngleAxis(_rotationY, Vector3.left);
    }




}
