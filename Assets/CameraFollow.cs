using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	GameObject _player;
	float _distanceX;
	
	// Use this for initialization
	void Start () {
		_player = GameObject.FindGameObjectWithTag("Player");
		_distanceX = this.transform.position.x - _player.transform.position.x;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		var x = _player.transform.position.x + _distanceX; //this.transform.position.x;
		var y = this.transform.position.y;
		var z = this.transform.position.z;
		
		transform.position = new Vector3(x, y, z);
	}
}
