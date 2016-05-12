using UnityEngine;
using System.Collections;

public class sketch : MonoBehaviour {

	public GameObject myPrefab;

	// Use this for initialization
	void Start () {

		int totalCubes = 12;
		int totalDistance = 5;

		// SIN Distribution
		// basic trig
		// https://www.khanacademy.org/math/trigonometry/trigonometry-right-triangles/intro-to-the-trig-ratios/v/basic-trigonometry
		for (int i = 0; i < totalCubes; i++) 
		{
			float percent = i / (float) totalCubes;

			// we only want the range between 0 and 90 degrees
			// since we cant use degrees, we use radians
			// (Mathf.PI / 2) = 90 degrees
			// https://www.youtube.com/watch?v=BO337LB5Gj0#t=368.625562
			float sin = Mathf.Sin (percent * (Mathf.PI / 2));

			float x = sin * totalDistance;
			float y = 6.0f;
			float z = 0;

			var newCube = (GameObject)Instantiate (myPrefab, new Vector3(x, y, z), Quaternion.identity);
			//						newCube.GetComponent<myCubeScript> ().rotateSpeed = Random.Range(0.1f, 0.5f);
			//						newCube.GetComponent<myCubeScript> ().rotateSpeed = percent;

			newCube.GetComponent<myCubeScript> ().rotateSpeed = 0;
			newCube.GetComponent<myCubeScript> ().setSize (1.0f - percent);		
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
