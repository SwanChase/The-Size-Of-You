using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : PlayerMovementData {

    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move(bool up, bool down, bool left, bool right) {
        Vector3 toMove = new Vector3();

        if (up && down) {
            up = down = false;
        } else if (up) {
            toMove.y = 1;
        } else if (down) {
            toMove.y = -1;
        } else {
            toMove.y = 0;
        }

        if (left && right) {
            left = right = false;
        } else if (left) {
            toMove.x = -1;
        } else if (right) {
            toMove.x = 1;
        } else {
            toMove.x = 0;
        }

        rigidbody.AddForce(toMove * movementSpeed);
    }
}
