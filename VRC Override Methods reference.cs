using NUnit.Framework.Interfaces;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class OverrideList : UdonSharpBehaviour
{
    //
    // More info
    // https://docs.vrchat.com/docs/event-nodes#onspawn
    //
    public override void Interact()
    {
        // runs when you Interact with an object
    }

    public override void OnSpawn()
    {
        //Runs when you spawn an object
    }

    public override void OnOwnershipTransferred()
    {
        //Runs when this object changes owners
        //
        //Extra note:
        //Picking up an object transfers ownership
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
