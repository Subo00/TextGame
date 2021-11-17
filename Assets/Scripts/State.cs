using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    
    [SerializeField] private string  titleText;
    //14-min size of filed, 10- num of lines before scrol
    [TextArea(14,10)][SerializeField] private string storyText;
    [SerializeField] private string[] actions;
    [SerializeField] private State[] nextStates;

   public string GetStateStory()
   {
       return storyText;
   }

    public string GetStateTitle()
    {
        return titleText;
    }

   public State[] GetNextState( )
   {
       return nextStates;
   }

   public string[] GetStateActions()
   {
       return actions;
   }
}
