﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EventSystem;

public class InputManager : MonoBehaviour
{
    private void Update()
    {
        keyboardKey();
        mouseClick();
        scrollWheel();
    }

    private void FixedUpdate()
    {
        playerMovement();
    }

    private void playerMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        EventManager.get().Notify(new MovementInputEvent(moveHorizontal, moveVertical));
    }

    private void keyboardKey()
    {
        if (Input.GetKey(KeyCode.R))
            EventManager.get().Notify(new ResetRequestedEvent());
    }

    private void mouseClick()
    {
        if (Input.GetMouseButtonDown(0))
            EventManager.get().Notify(new MouseClickEvent(KeyCode.Mouse0));

        if (Input.GetMouseButtonDown(1))
            EventManager.get().Notify(new MouseClickEvent(KeyCode.Mouse1));

        if (Input.GetMouseButtonDown(2))
            EventManager.get().Notify(new MouseClickEvent(KeyCode.Mouse2));
    }

    private void scrollWheel()
    {
        float axis = Input.GetAxis("Mouse ScrollWheel");

        if (axis != 0.0f)
        {
            EventManager.get().Notify(new WheelActionEvent(axis));
        }
    }
}
