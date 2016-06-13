using UnityEngine;
using KC = UnityEngine.KeyCode;

[RequireComponent(typeof (PlayerMovement))]
public class KeyboardInput : KeyboardInputData {


    void Start() {
        pm = GetComponent<PlayerMovement>();
    }

    void Update() {
        KeyDown();
        SendKeys();
    }

    void KeyDown() {
        up = GetKey(KC.W) || GetKey(KC.UpArrow);
        right = GetKey(KC.D) || GetKey(KC.RightArrow);
        down = GetKey(KC.S) || GetKey(KC.DownArrow);
        left = GetKey(KC.A) || GetKey(KC.LeftArrow);
        pause = GetKeyDown(KC.Escape);
    }

    void SendKeys() {
        pm.Move(up, down, left, right);
    }

    // Lazyness...
    // Don't have to type "Input." now.
    bool GetKey(KC key) {
        return Input.GetKey(key);
    }

    bool GetKeyDown(KC key) {
        return Input.GetKeyDown(key);
    }

    bool GetKeyUp(KC key) {
        return Input.GetKeyUp(key);
    }
}
