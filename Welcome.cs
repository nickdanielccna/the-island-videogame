using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Chapter1
{
public class Welcome : MonoBehaviour 
{
private string myMessage = "Welcome";
public Text textWelcome;
public GameObject canvasWelcome;

	// Use this for initialization
	void Start () {
		MyWelcomeMessage();
	}
	//calling methods in startup funtions 
	void SetInitialReferences()
	{
		textWelcome = GameObject.Find("TextWelcome").GetComponent<Text>();
	}

	void MyWelcomeMessage ()
	{
		if (textWelcome != null)
		{
			textWelcome.text = myMessage;
		}
		else
		{
			Debug.LogWarning("WelcomeText not assigned.");
		}

		StartCoroutine(DisableCanvas());
		
	}

	IEnumerator DisableCanvas()
	{
		yield return new WaitForSeconds(3.5f);
		canvasWelcome.SetActive(false);
	}

	
}


}
