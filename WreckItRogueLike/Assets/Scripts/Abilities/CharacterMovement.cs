using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : CharacterAbilities
{
    [SerializeField] private float walkSpeed = 6f;

    public float walkMoveSpeed { get; set; }

    protected override void Start()
    {
        base.Start();
        walkMoveSpeed = walkSpeed;
    }

    protected override void HandleAbility()
    {
        base.HandleAbility();
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        Vector2 movementNormalized = movement.normalized;
        Vector2 movementSpeed = movementNormalized * walkMoveSpeed;
        controller.SetMovement(movementSpeed);
    }
}
