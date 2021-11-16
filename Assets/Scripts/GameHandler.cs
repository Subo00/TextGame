using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    [SerializeField] Text titleComponent;
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;
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
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextState();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        UpdateState();
    }
}
