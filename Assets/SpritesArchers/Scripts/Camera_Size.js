#pragma strict
var distance = 3.0;
 var distanceMin = 3;
var distanceMax = 20; 

function Start () {

}

function Update () {

distance = Mathf.Clamp(distance - Input.GetAxis("Mouse ScrollWheel")*5, distanceMin, distanceMax);
GetComponent.<Camera>().main.orthographicSize = distance;

}