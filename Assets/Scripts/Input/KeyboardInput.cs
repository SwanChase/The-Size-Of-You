using UnityEngine;
using IP = UnityEngine.Input;
using KC = UnityEngine.KeyCode;

[RequireComponent(typeof (PlayerMovement))]
public class KeyboardInput : KeyboardInputData {

    void Start() {
        pm = GetComponent<PlayerMovement>();
    }

    void Update() {
        UpdateToMove();
        SendToMove();
    }

    void UpdateToMove() {
        bool up, right, down, left = false;

        up = IP.GetKey(KC.W);
        right = IP.GetKey(KC.D);
        down = IP.GetKey(KC.S);
        left = IP.GetKey(KC.A);

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
    }

    void SendToMove() {
        pm.Move(toMove);
    }
}
