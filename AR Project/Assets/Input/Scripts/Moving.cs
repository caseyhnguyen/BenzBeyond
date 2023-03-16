using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Moving : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.DrivingActions driving;

    private PlayerMotor motor;
    private PlayerLook look;

    private void Awake()
    {
        playerInput = new PlayerInput();
        driving = playerInput.Driving;
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();
    }

    void FixedUpdate()
    {
        motor.ProcessMove(driving.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        look.ProcessLook(driving.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        driving.Enable();
    }

    private void OnDisable()
    {
        driving.Disable();
    }
}
