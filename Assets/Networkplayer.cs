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
        if (!Nwtworko.IsOwner )
        {
            Destroy(GetComponentInChildren<Camera>().gameObject);
            GetComponent<Actor>().Affiliation = 0;

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Nwtworko.IsOwner && Nwtworko.IsPlayerObject)
        {
           GetComponent<PlayerCharacterController>().m_InputHandler = GetComponent<PlayerInputHandler>();
            GetComponent<PlayerCharacterController>().m_Controller = GetComponent<CharacterController>();
        }
        else
        {
            GetComponent<PlayerCharacterController>().m_InputHandler =null;
            //GetComponent<PlayerCharacterController>().m_Controller = null;
        }
            
    }
}
