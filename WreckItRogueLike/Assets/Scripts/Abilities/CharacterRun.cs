using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRun : CharacterAbilities
{
    [SerializeField] private float runSpeed = 10f;

    protected override void HandleInput()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Start running
            Run();
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            // Stop running
            StopRun();
        }
    }

    private void Run()
    {
        characterMovement.MoveSpeed = runSpeed;
    }

    private void StopRun()
    {
        characterMovement.ResetSpeed();
    }
}
