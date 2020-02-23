using UnityEngine;
using UnityEngine.Events;

public class CommandFamiliar_Position : UnityEvent<FamiliarCommands, Vector3> { }

public class CommandFamiliar_GameObject : UnityEvent<FamiliarCommands, GameObject> { }
