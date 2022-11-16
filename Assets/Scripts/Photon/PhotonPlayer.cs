using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO; 

public class PhotonPlayer : MonoBehaviour
{
    private PhotonView PV;
    public GameObject myMonsterAvatar;
    void Start()
    {
        PV = GetComponent<PhotonView>();
        int spawnPicker = Random.Range(0, GameSetUp.GS.spawnpoints.Length);

        if(PV.IsMine)
        {
            myMonsterAvatar = PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "MonsterAvatar"),
            GameSetUp.GS.spawnpoints[spawnPicker].position, GameSetUp.GS.spawnpoints[spawnPicker].rotation, 0);
        }
    }

    
    void Update()
    {
        
    }
}
