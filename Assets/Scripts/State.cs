using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    
    [SerializeField] private string  titleText;
    //14-min size of filed, 10- num of lines before scrol
    [TextArea(14,10)][SerializeField] private string storyText;
    [SerializeField] private List<string> actions;
    [SerializeField] private List<State> nextStates;

    [SerializeField] private Sprite sprite;
    

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

   public Sprite GetStateSprite()
   {
       return sprite;
   }

   public bool HasSprite()
   {
       if(sprite != null)
       return true;
       else
       return false;
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
