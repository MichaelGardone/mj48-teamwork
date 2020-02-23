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

    public Color GetColorFromCommand(FamiliarStatus command)
    {
        switch (command)
        {
            case FamiliarStatus.FOLLOW:
                return FollowColor;               
            case FamiliarStatus.MOVE:
                return MoveColor;  
            case FamiliarStatus.ATTACK:
                return AttackColor;
            case FamiliarStatus.RETRIEVE:
                return RetrieveColor;
            case FamiliarStatus.INTERACT:
                return InteractColor;
            default:
                return Color.white;
                
        }
    }
}
