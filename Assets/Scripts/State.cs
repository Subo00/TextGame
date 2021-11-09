using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //14-min size of filed, 10- num of lines before scrol
   [TextArea(14,10)][SerializeField] string storyText;
   [SerializeField] State[] nextStates;

   public string GetStateStory()
   {
       return storyText;
   }

   public State[] GetNextState( )
   {
       return nextStates;
   }
}
