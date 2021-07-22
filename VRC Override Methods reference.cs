using UdonSharp;
using VRC.SDK3.Components.Video;
using VRC.SDKBase;
using VRC.Udon.Common;

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

    /*
     * Overship transfers
     */
    public override void OnOwnershipTransferred(VRCPlayerApi _player)
    {
        //Runs when this object changes owners
        //
        //Extra note:
        //Picking up an object transfers ownership
    }
    public override bool OnOwnershipRequest(VRCPlayerApi _requestingPlayer, VRCPlayerApi _currentOwner)
    {
        //When an object tries to transfer Ownship
        //this will run allowing you to define if ownership is allowed to transfer.
        //
        //If this isnt present in your code it will retruen True by default allowing the owner to change.
        return true;
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
    public override void OnPlayerJoined(VRCPlayerApi _player)
    {
        //Runs when a player joins
        //Returns that player that joined
    }

    public override void OnPlayerLeft(VRCPlayerApi _player)
    {
        //runs when a player leaves
        //Returns that player that left
    }

    /*
     * Stations
     * These are what chairs use to work
     */
    public override void OnStationEntered(VRCPlayerApi _player)
    {
        //Runs when you enter a chair
    }
    public override void OnStationExited(VRCPlayerApi _player)
    {
        //Runs when you leave a chair
    }

    /*
     * Video Player
     * 
     * These need to be on an VideoPlayer component to work
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
        //When a video starts playing, this can include:
        //Video first starts
        //UnPausing a video
    }
    public override void OnVideoStart()
    {
        //Runs when a video player starts from a stopped state.
        //seems to be the same as OnVideoPlay()
    }
    public override void OnVideoLoop()
    {
        //Runs when a video loops
    }
    public override void OnVideoReady()
    {
        //Runs when a video loads in and is ready to be played, but not when the video plays.
    }
    public override void OnVideoError(VideoError videoError)
    {
        //Requires "using VRC.SDK3.Components.Video;" to be used
    }
    /*
     * Serialization
     */
    public override void OnDeserialization()
    {
        //This runs whenever the client recives Networking data.
    }
    public override void OnPreSerialization()
    {
        //This runs before the client sends Networking data.
    }
    public override void OnPostSerialization(SerializationResult result)
    {
        //requires "using VRC.Udon.Common;" to use

        //From what i understand this
        //runs after all other Serialization event and allows you top check if it was sent successfully.
    }

    /*
     * MIDI
     */
    public override void MidiControlChange(int channel, int number, int value)
    {
        //Runs when a Control changes on the MIDI controller. this basically anything that isnt a note
        //Examples beiong a slider, a knob, or a sustain pedal
    }
    public override void MidiNoteOn(int channel, int number, int velocity)
    {
        //Runs when you push a MIDI note
    }
    public override void MidiNoteOff(int channel, int number, int velocity)
    {
        //Runs when you let go of a MIDI note
    }
}
