using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class OverrideList : UdonSharpBehaviour
{
    public override void Interact()
    {
        // runs when you Interact with an object
    }

    /*
     * Pickups
     * These must be attached to an object with VRC_Pickup on it
     */
    public override void OnPickup()
    {
        //Runs for the player that pickups the object
    }
    public override void OnDrop()
    {
        //Runs for the player that drops the object
    }
    public override void OnPickupUseDown()
    {
        //Runs for the player that uses the pickup
    }
    public override void OnPickupUseUp()
    {
        //Runs for the player that stops using the pickup
    }

    /*
     * Player join / leave
     */
    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        //Runs when a player joins
        //Returns that player that joined
    }

    public override void OnPlayerLeft(VRCPlayerApi player)
    {
        //runs when a player leaves
        //Returns that player that left
    }

    /*
     * Stations
     * These are what chairs use to work
     */
    public override void OnStationEntered()
    {
        //Runs when you enter a chair
    }
    public override void OnStationExited()
    {
        //Runs when you leave a chair
    }

}
