using UnityEngine;
using System.Collections;

public class ClicktoRun : MonoBehaviour {

	private int f=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0)){
			if(f==0){
				GetComponent<Animator> ().SetBool ("run_1",true);
				f=1;
			}else{
				GetComponent<Animator> ().SetBool ("run_1",false);
				f=0;
			}
		}
	
	}

	/*void OnMouseOver() {
		if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0)){
			if(f==0){
				GetComponent<Animator> ().SetBool ("run_1",true);
				f=1;
			}else{
				GetComponent<Animator> ().SetBool ("run_1",false);
				f=0;
			}
		}
	}*/
}
