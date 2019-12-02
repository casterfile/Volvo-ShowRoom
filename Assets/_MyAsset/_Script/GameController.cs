using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject Popup01;
	// Use this for initialization
	void Start () {
        Popup01.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowPopup()
    {
        Popup01.SetActive(false);
    }
}
