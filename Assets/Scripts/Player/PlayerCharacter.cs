using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] int _health = 5;
    int myrtpc = 5;
    private void Start(){
        AkSoundEngine.SetRTPCValue("Music_RTPC", myrtpc);
        AkSoundEngine.PostEvent("GameMusicEvent", gameObject);
    }
    public void Hurt(int damage)
    {
        _health -= damage;
        myrtpc -= 1; 
        AkSoundEngine.SetRTPCValue("Music_RTPC", myrtpc);
        AkSoundEngine.PostEvent("GruntPlay", gameObject);
        Debug.Log($"Health: {_health}");
        Debug.Log($"MyRTPC: {myrtpc}");
    }
}
