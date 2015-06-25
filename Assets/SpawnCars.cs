using UnityEngine;
using System.Collections;

public class SpawnCars : MonoBehaviour {

	public GameObject _car;
	public float _lastPosition;
	
	// Use this for initialization
	void Start () {
		InstantiateCar();
	}
	
	// Update is called once per frame
	void Update () {

		if(this.transform.position.x - _lastPosition > 20f) {
			InstantiateCar();
		}	
	}
	
	void InstantiateCar()
	{
		_lastPosition = this.transform.position.x;
		Instantiate(_car, this.transform.position, Quaternion.identity);
	}
}
