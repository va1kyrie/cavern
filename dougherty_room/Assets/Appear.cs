using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour {

	void Start(){
	}
		

	IEnumerator OnTriggerEnter(Collider obj){
		if (obj.gameObject.CompareTag ("Player")) {
			//move each stair down gracefully
			//it's probably not going to be graceful but i can dream
			foreach(Transform child in transform) {
				child.gameObject.SetActive (true);

				yield return new WaitForSeconds(1);
			}

			//foreach(Transform child in transform) {
			//	child.transform.GetChild(0).gameObject.SetActive (true);

				//child.transform.Translate (0, 0, zMove, Camera.main.transform);
			//	yield return new WaitForSeconds(1);
			//}
		}
	}
}
