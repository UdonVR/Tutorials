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

    /*
     * Video Player
     * 
     * There currently isnt a video player for Udon
     * so none of these will work
     * however they're still included with Udon
     * 
     * When they bring the video player back
     * these will have to be attached to an
     * object with the video Sync component
     */
    public override void OnVideoEnd()
    {
        //When a video ends
    }
    public override void OnVideoPause()
    {
        //When a video pauses
    }
    public override void OnVideoPlay()
    {
        //When a start playing vis any source
        //First starting a video
        //UnPausing
        //Next video in que
    }
    public override void OnVideoStart()
    {
        //When a video player starts from a stopped state
    }

    /*
     * Serialization
     * 
     * This is something network related i never dug into
     * i know there are uses for them,
     * but i dont know how to use them
     */
    public override void OnDeserialization()
    {
        
    }
    public override void OnPreSerialization()
    {
        
    }

}
