using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //14-min size of filed, 10- num of lines before scrol
    [SerializeField] string  titleText;
    [TextArea(14,10)][SerializeField] string storyText;
    [SerializeField] State[] nextStates;

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
}
