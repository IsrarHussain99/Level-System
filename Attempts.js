#pragma strict
var Counter : int = 6;      
var GameOver : boolean = false;
var Pause : GameObject; 
var Replay : GameObject; 
var MainM : GameObject;
 
function React () 
{            
  Counter--;     
}
  // minus the attempts setup

function Update () 
 {    GetComponent.<GUIText>().text = "Attempts: "+Counter;   
 // how it will react 
if (Counter<0){

Debug.Log("zerod");
var GameOver = true;

if (GameOver)
  Pause.active = true;
  Replay.active = true;
  MainM.active = true;
  }
  }


  //loads gameover scene    



    