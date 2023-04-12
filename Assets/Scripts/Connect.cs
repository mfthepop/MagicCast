using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Connect : MonoBehaviour
{
    public GameObject hostbutton;
    public GameObject clientbutton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Host()
    {
        NetworkManager.Singleton.StartHost();
        Debug.Log("hello illia");
        hostbutton.SetActive(false);
        clientbutton.SetActive(false);
    }

    public void Client()
    {
        NetworkManager.Singleton.StartClient();
        Debug.Log("Bye Illia");
        clientbutton.SetActive(false);
        hostbutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
