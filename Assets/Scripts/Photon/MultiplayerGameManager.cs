using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class MultiplayerGameManager : MonoBehaviourPunCallbacks
{
    string gameVer = "1";
    void Start()
    {
        Connect();
    }
    public void Connect()
    {
        if (PhotonNetwork.IsConnected)
        {
                // #Critical we need at this point to attempt joining a Random Room. If it fails, we'll get notified in OnJoinRandomFailed() and we'll create one.
                //PhotonNetwork.JoinRandomRoom();
                
            }
            else
            {
                // #Critical, we must first and foremost connect to Photon Online Server.
                PhotonNetwork.GameVersion = gameVer;
                PhotonNetwork.ConnectUsingSettings();
            }
    }
    void Update()
    {
        
    }
}
