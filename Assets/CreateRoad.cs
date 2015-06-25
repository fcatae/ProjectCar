using UnityEngine;
using System.Collections;

public class CreateRoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerExit(Collider col)
	{
		//if(col.tag == "Road")
		if(col.tag == "CityBlock") 
		{
			col.transform.Translate(120*3, 0, 0);
		}
		
		if(col.tag == "Car")
		{
			DestroyObject(col.gameObject);
		}
	}
}
