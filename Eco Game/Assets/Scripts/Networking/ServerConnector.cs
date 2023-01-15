using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ServerConnector : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.ConnectToRegion("eu");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("LobbyPlaceholder");
    }
}
