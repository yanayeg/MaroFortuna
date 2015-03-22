var models : GameObject[] = new  GameObject[5];

var active_model : int;

public static var actual_go : GameObject;


function OnMouseDown() 
{
 	HideItem();
	active_model++;
	//print(active_item);
	models[active_model].SetActive(true);
	actual_go = models[active_model];
	if (active_model >models.GetLength(0)-2) active_model=-1;
}

function HideItem(){
for(var i=0; i<models.GetLength(0); i++)
models[i].SetActive(false);

}











