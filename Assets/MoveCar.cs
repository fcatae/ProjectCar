using UnityEngine;
using System.Collections;

public class MoveCar : MonoBehaviour {

	public float _speed = 5;
	public float _drift = 2;
	Vector3 _lastPosition;
	public Vector3 _velocity;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		_lastPosition = transform.position;
		
		transform.Translate(Time.deltaTime * _speed, 0, 0);
		var horizontal = Input.GetAxis("Horizontal"); 
		
		if(horizontal != 0)
		{
			transform.Rotate(Vector3.up, horizontal);
				//transform.Translate(0, 0, - horizontal * _drift);
		}
		
		var vertical = Input.GetAxis("Vertical");
		if(vertical != 0)
		{
			_speed += vertical;
		}
		
	}
	
	void OnCollisionEnter(Collision col)
	{
		//var vel = transform.rotation * Vector3.forward * _speed * 3;
		var vel = (transform.position - _lastPosition) * 20 +  Vector3.up * 5 + Vector3.forward * 5;
		
		_velocity = vel;
		
		var somebody = col.rigidbody; 
		if(somebody)
		{
			somebody.AddForce(vel, ForceMode.Impulse);
		}
	}
}
