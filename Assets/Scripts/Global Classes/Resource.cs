using UnityEngine;
using System.Collections;

public class Resource : MonoBehaviour {

	public string rscName;
	public string type;
	public int quantity;

	public Resource(){
	}

	public Resource(string rscName, string type, int quantity){
		this.rscName = rscName;
		this.type = type;
		this.quantity = quantity;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
