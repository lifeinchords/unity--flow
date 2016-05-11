using UnityEngine;
using System.Collections;

public class sketch : MonoBehaviour {

	public GameObject myPrefab;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 3; i++) 
		{
			float x = 3.0f;
			float y = 5.0f;
			float z = 0;

			var newCube = (GameObject)Instantiate (myPrefab, new Vector3(x, y, z), Quaternion.identity);
			newCube.GetComponent<myCubeScript> ().rotateSpeed = 10f;
			newCube.GetComponent<myCubeScript> ().setSize (2);		
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
