using UnityEngine;
using System.Collections;

public class myCubeScript : MonoBehaviour {

	public float rotateSpeed = 1.0f;
	public Vector3 spinSpeed = Vector3.zero;
	public Vector3 spinAxis = Vector3.up;
	// 
	// Use this for initialization
	void Start () {
		setSize (2.0f);
		this.transform.position = new Vector3 (0, 5, 3);
		spinSpeed = new Vector3 (Random.value, Random.value, Random.value); 

		// quick algorithm for range between -1 and 1
		// dampen, by multiplying by 0.1
		spinAxis.x = (Random.value - Random.value) * 0.1f;

	}

	public void setSize(float size)
	{
		this.transform.localScale = new Vector3(size, size, size);
	}

	// Update is called once per frame
	void Update () {
		this.transform.Rotate (spinSpeed);
		this.transform.RotateAround (Vector3.zero, spinAxis, rotateSpeed);
	}
}
