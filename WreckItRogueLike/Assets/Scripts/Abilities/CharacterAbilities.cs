using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAbilities : MonoBehaviour
{
    protected float horizontalInput;
    protected float verticalInput;

    protected CharacterController controller;
    protected CharacterMovement characterMovement;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        controller = GetComponent<CharacterController>();
        characterMovement = GetComponent<CharacterMovement>();
    }

    // Update ability being used
    protected virtual void Update()
    {
        HandleAbility();
    }

    // Main method. Adds logic  for each ability
    protected virtual void HandleAbility()
    {
        InternalInput();
        HandleInput();
    }

    // Receive needed input to perform ability
    protected virtual void HandleInput()
    {

    }

    // Receive input needed to control the character
    protected virtual void InternalInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
}
