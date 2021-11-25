using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StateFlag : MonoBehaviour
{
    public string trigger; //what state is the falg trigger
    public State stateChange; //state to change
    public State stateAdd; //state to add/remove
    public string action; //action for the added/removed state
    public bool isAdd; 
}
