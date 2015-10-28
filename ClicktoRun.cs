using UnityEngine;
using System.Collections;

public class ClicktoRun : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver() {
		if (Input.GetMouseButtonDown (0) || (Input.touchCount > 0)){
			if(GetComponent<Animator> ().GetInteger("run")==0){
				GetComponent<Animator> ().SetInteger ("run",1);
			}else{
				GetComponent<Animator> ().SetInteger ("run",0);
			}
		}
	}
}
