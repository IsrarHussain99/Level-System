#pragma strict

public var ConfirmButton : GameObject;
public var YesButtonObject : GameObject; 
public var NoButtonObject : GameObject; 

public static var Confirmed : boolean = false;

ConfirmButton.active = false;

function Start () {

}

function Update () {

//if(Confirmed)


}

function ConfirmButtonUp ()
{
ConfirmButton.active = true;
}


function YesButton ()
{
Confirmed = true;
//transaction will now take place! (in the other scripts!)

//go to inventory
//SceneManager.LoadScene("StoreScene");

}

function NoButton ()
{
ConfirmButton.active = false;


}