using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ServerConnector : MonoBehaviour
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
}
