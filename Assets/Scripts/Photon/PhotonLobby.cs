using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonLobby : MonoBehaviourPunCallbacks
{
    public static PhotonLobby lobby;
    public GameObject battleButton;
    public GameObject cancelButton;

    private void Awake()
    {
        //To access this instance of the photon lobby at the start
        //Creates the singleton, lives within the Main Menu Scene 
        lobby = this;
    }
    void Start()
    {
        //Connects to Master Photon Server
        PhotonNetwork.ConnectUsingSettings();
    }
    
    public override void OnConnectedToMaster()
    {
        //Player is now connected to Photon Master Server, enables the button to join the game 
        Debug.Log("Player has connected to Master Photon Server");
        //Whenever the master client calls PhotonNetwork.LoadLevel, that will be synchronized across all clients
        PhotonNetwork.AutomaticallySyncScene = true;
        battleButton.SetActive(true);
    }
    
    public void OnBattleButtonClicked()
    {
        Debug.Log("BattleButton was Clicked");
        battleButton.SetActive(false);
        cancelButton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();
    }
    
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Tried to join a random room but failed. No available Rooms");
        CreateRoom();
    }

    void CreateRoom()
    {
        Debug.Log("Trying to Create a New room");
        int randomRoomName = Random.Range(0, 10000);
        RoomOptions roomOps = new RoomOptions() {IsVisible = true, IsOpen = true, MaxPlayers = 4};
        PhotonNetwork.CreateRoom("Room" + randomRoomName, roomOps);
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Tried to create a room but failed. A room with the same name might exist");
        CreateRoom();
    }
    public void OnCancelButtonClicked()
    {
        Debug.Log("CancelButton was Clicked");
        battleButton.SetActive(false);
        cancelButton.SetActive(true);
        PhotonNetwork.LeaveRoom();
    } 
    void Update()
    {
        
    }
}
