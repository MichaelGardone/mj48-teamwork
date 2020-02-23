using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Rune Definition", menuName = "Rune Definition")]
public class RuneDefinition :ScriptableObject
{
    public Color FollowColor;
    public Color RetrieveColor;
    public Color InteractColor;
    public Color MoveColor;
    public Color AttackColor;

    public Color GetColorFromCommand(FamiliarCommands command)
    {
        switch (command)
        {
            case FamiliarCommands.FOLLOW:
                return FollowColor;               
            case FamiliarCommands.MOVE:
                return MoveColor;  
            case FamiliarCommands.ATTACK:
                return AttackColor;
            case FamiliarCommands.RETRIEVE:
                return RetrieveColor;
            case FamiliarCommands.INTERACT:
                return InteractColor;
            default:
                return Color.white;
                
        }
    }
}
