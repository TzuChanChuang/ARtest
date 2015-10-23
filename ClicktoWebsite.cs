using UnityEngine;
using System.Collections;

public class ClicktoWebsite : MonoBehaviour {
	
	public string url = "https://developer.vuforia.com/";
	void OnMouseOver() {
		if (Input.GetMouseButtonDown(0) ||  (Input.touchCount >  0))
			Application.OpenURL(url);
	}
}