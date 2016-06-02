using UnityEngine;

public class PlayerMovementData : MonoBehaviour {

    protected Rigidbody2D rigidbody;

    [SerializeField] // How fast I'll move.
    protected float movementSpeed;
}
