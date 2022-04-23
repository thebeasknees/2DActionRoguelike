using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFlip : CharacterAbilities
{
    public enum FlipMode
    {
        MovementDirection,
        WeaponDirection
    }

    [SerializeField] private FlipMode flipMode = FlipMode.MovementDirection;
    [SerializeField] private float threshold = 0.1f;

    protected override void HandleAbility()
    {
        base.HandleAbility();
        if(flipMode == FlipMode.MovementDirection)
        {
            FlipToMoveDirection();
        }
        else
        {
            FlipToWeaponDirection();
        }
    }

    private void FlipToMoveDirection()
    {
        if(controller.CurrentMovement.normalized.magnitude > threshold)
        {
            if(controller.CurrentMovement.normalized.x > 0)
            {
                FaceDirection(1);
            }
            else if(controller.CurrentMovement.normalized.x < 0)
            {
                FaceDirection(-1);
            }
        }
    }

    private void FlipToWeaponDirection()
    {
        //------------------
    }

    private void FaceDirection(int newDirection)
    {
        if(newDirection == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
