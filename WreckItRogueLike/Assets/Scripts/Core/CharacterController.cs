using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Vector2 CurrentMovement { get; set; }
    public bool NormalMovement { get; set; }

    private Rigidbody2D myRigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
        NormalMovement = true;
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (NormalMovement)
        {
            MoveCharacter();
        }  
    }

    private void MoveCharacter()
    {
        Vector2 currentMovePosition = myRigidbody2D.position + CurrentMovement * Time.fixedDeltaTime;
        myRigidbody2D.MovePosition(currentMovePosition);
    }

    public void MovePosition(Vector2 newPostion)
    {
        myRigidbody2D.MovePosition(newPostion);
    }

    public void SetMovement(Vector2 newPosition)
    {
        CurrentMovement = newPosition;
    }
}
