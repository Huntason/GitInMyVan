using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("hit me good");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x+1, 0, 0);
	}
}
