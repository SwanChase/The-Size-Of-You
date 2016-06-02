using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : PlayerMovementData {

    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector3 toMove) {
        rigidbody.AddForce(toMove * movementSpeed);
    }
}
