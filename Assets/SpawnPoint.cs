using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {

	public GameObject debri;

	public float interval = 1f;

	void Start () {

		StartCoroutine ("SpawnDebris");
	
	}

	IEnumerator SpawnDebris() {

		while(true){

			Instantiate(debri, transform.position, Quaternion.identity);

			yield return new WaitForSeconds(interval);
		}
	}

}
