using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionsHUB : MonoBehaviour {

    // Use this for initialization

    public Text numMonedas;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        numMonedas.text = GameInformation.NumMonedas.ToString();
	}
}
