#pragma strict
var HasCollided = false;
 var StartPosition : Transform;
 var respawntriggers : GameObject;

function OnTriggerEnter (theTrigger : Collider)
{
 if(theTrigger.gameObject.name == "RespawnTimeStart")
{
var HasCollided = true;
//once it touches triggers
 respawntriggers.active = false; 
 //the triggers will shutdown

Debug.Log("triggers have shutdown");
}

{
if(HasCollided)
//if the HasCollided is true this will work
{

HasCollided = false;
//this turns HasCollided off 
Debug.Log("HASCOll = false");

  yield WaitForSeconds(6.0);
  Debug.Log("waited 6 seconds");
  //wait 6 seconds

  GetComponent.<Rigidbody>().velocity = Vector3.zero; 
  // stops ball movement


       GetComponent.<Rigidbody>().position = StartPosition.position;
       //respawns are startposition
       Debug.Log("respwaning"); 

gameObject.Find("Attempts").SendMessage("React");       
       Debug.Log("MinusAttempts");  
       }
 }
        respawntriggers.active = true;
        //triggers turn back on


}    


