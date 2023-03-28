using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Connect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Host()
    {
        NetworkManager.Singleton.StartHost();
    }

    public void Client()
    {
        NetworkManager.Singleton.StartClient();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
