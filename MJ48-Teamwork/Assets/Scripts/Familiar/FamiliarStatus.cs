
public enum FamiliarStatus
{
    // Follow the player around the map
    FOLLOW,

    // Go to the location
    MOVE,

    // Go to the location and attack
    ATTACK,

    // Go to the location, grab the item, and return
    RETRIEVE,

    // Interact with the character/object
    INTERACT,

    // For when the familiar is doing something else and can't hear the player
    DISTRACTED,

}

