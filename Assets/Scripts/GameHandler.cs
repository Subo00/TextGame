using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private Text titleComponent;
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;
    [SerializeField] private Button[] buttons;
    private int numOfActions = 5;

    private  State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        UpdateState();
    }

    private void UpdateState()
    {
        textComponent.text = state.GetStateStory();
        titleComponent.text = state.GetStateTitle();
        ManageButtons();
        Debuging();
    }

    private void Debuging()
    {
        var futureStates = state.GetNextState();
        for(int i = 0; i < futureStates.Length; i++)
        {
            Debug.Log("Current state: "+ state + ", next state "+ futureStates[i]);
        }
    }

    private void ManageButtons()
    {
        var actions = state.GetStateActions();
        for(int i = 0; i < numOfActions; i++)
        {
            buttons[i].gameObject.SetActive(false); //disables the buttons if they aren't needed
            if(actions.Length > i)
            {
                buttons[i].gameObject.SetActive(true); //enable buttons that are needed
                buttons[i].GetComponentInChildren<Text>().text = actions[i]; //change the text to the action 
                int nextState = i;
                buttons[i].onClick.RemoveAllListeners(); //remove the previous listeners
                buttons[i].onClick.AddListener(()=> ChangeState(nextState)); //when you click on a button, change state
                
            }
           
        }
    }

  
    private void ChangeState(int nextState)
    {
        var futureStates = state.GetNextState();
        state = futureStates[nextState];
        UpdateState();
    }
}
