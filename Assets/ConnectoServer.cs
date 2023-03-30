using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Unity.FPS.UI;
using UnityEngine.SceneManagement;


public class ConnectoServer : MonoBehaviourPunCallbacks
{
    private void Start() 
    {
        PhotonNetwork.ConnectUsingSettings();
      
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }


}
