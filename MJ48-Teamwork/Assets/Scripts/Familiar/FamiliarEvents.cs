using UnityEngine;
using UnityEngine.Events;

public class CommandFamiliar_Position : UnityEvent<FamiliarStatus, Vector3> { }

public class CommandFamiliar_GameObject : UnityEvent<FamiliarStatus, GameObject> { }
