using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    
    [SerializeField] private string  titleText;
    //14-min size of filed, 10- num of lines before scrol
    [TextArea(14,10)][SerializeField] private string storyText;
    [SerializeField] private List<string> actions;
    [SerializeField] private List<State> nextStates;
    

   public string GetStateStory()
   {
       return storyText;
   }

    public string GetStateTitle()
    {
        return titleText;
    }

   public List<State> GetNextState( )
   {
       return nextStates;
   }

   public List<string> GetStateActions()
   {
       return actions;
   }

   public void RemoveAction(string action, State state)
   {
       actions.Remove(action);
       nextStates.Remove(state);
   }

   public void AddAction(string action, State state)
   {
       foreach(var act in actions)
       {
           if(act == action)
           return;
       }
       actions.Add(action);
       nextStates.Add(state);
   }

   
}
