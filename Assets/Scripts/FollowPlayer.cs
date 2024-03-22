using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;	// A variable that stores a reference to our Player
	public Vector3 offset;		// A variable that allows us to offset the position (x, y, z)
	
	// Update is called once per frame
	void Update () {
		// Set our position to the players position and offset it
		transform.position = player.position + offset;
	}
}
