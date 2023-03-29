using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode.Components;
using Unity.Netcode;
using Unity.FPS.Game;
using Unity.FPS.Gameplay;

public class Networkplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public NetworkObject Nwtworko;
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Nwtworko.IsOwner && Nwtworko.IsPlayerObject)
        {
            GetComponent<PlayerCharacterController>().m_InputHandler = GetComponent<PlayerInputHandler>();
        }
        else
        {
            GetComponent<PlayerCharacterController>().m_InputHandler =null;
        }
            
    }
}
