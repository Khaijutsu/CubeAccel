using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    // By declaring a public DataType var_name, we would create an empty slot under the main camera object
    public Transform player;
    public Vector3 offset;

    void Update() {
        // transfrom.position is the current position of the parent, which is main camera and we set it equal to the position of the player 
        transform.position = player.position + offset;
        
    }
}
