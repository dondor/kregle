using UnityEngine;
using System.Collections;

public class LogikaSkrypt : MonoBehaviour {
	public float x;
	public float y;
	public float z;
	public GameObject zestawPrefab;
	public GameObject kulaPrefab;
	private GameObject stary;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R) == true) {
			stary=GameObject.FindGameObjectsWithTag("kręgle")[0];
			GameObject 	starakula=GameObject.FindGameObjectsWithTag("kręgle")[1];
			DestroyObject(stary);
			DestroyObject(starakula);
			Instantiate (zestawPrefab, new Vector3 (x, y,z), Quaternion.identity);

			Instantiate(kulaPrefab,new Vector3(11.43f,8f,16f), Quaternion.identity);
		}
	}
}
