using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AvatarSetUp : MonoBehaviour
{
    private PhotonView PV;
    public int characterValue;
    public GameObject myCharacter;
    public Camera myCamera;
    public AudioListener myAl;
    void Start()
    {
        PV = GetComponent<PhotonView>();
        //Checks to make sure if it is the local player
        if(PV.IsMine)
        {
            //Allow all players that have joined the game after the rpc function has been sent to still recieve it            
            PV.RPC("RPC_AddCharacter", RpcTarget.AllBuffered, MonsterInfo.MI.mySelectedMonster);
        }
        else
        {
            Destroy(myCamera);
            Destroy(myAl);
        }
    }

    [PunRPC]
    void RPC_AddCharacter(int whichMonster)
    {
        //Save the value passed into this variable 
        characterValue = whichMonster;
        //Use all characters array and the parameter to determine which character is going to spawn, // PlayerInfo.PI.allCharacters
        //as well as set the position and rotation of this object, //position and rotation
        //set this character as a child to the player avatar, //transform
        myCharacter = Instantiate(MonsterInfo.MI.allMonsters[whichMonster], transform.position, transform.rotation, transform);
    }
    void Update()
    {
        
    }
}
