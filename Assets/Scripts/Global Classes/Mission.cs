using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Mission : MonoBehaviour{
	public string title;
	public string description;
	public string successDescription;

	public Mission(){
		//empty constructer
	}
	public Mission(string title, string description, string successDescription){
		this.title = title;
		this.description = description;
		this.successDescription = successDescription;
	}
}