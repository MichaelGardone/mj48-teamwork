using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneFXController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] RuneDefinition runeDefinition;
    public SpriteRenderer FXSprite;
    

    public void SpawnFXOfType(FamiliarCommands command)
    {
        Color runecolor = runeDefinition.GetColorFromCommand(command);
        FXSprite.color = runecolor;
        if(FXSprite.TryGetComponent<Animator>(out Animator a))
        {
            a.Play("RuneSpin");
        }
    }
}
