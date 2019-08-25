using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void OnClickMonsterPick(int whichMonster)
    {
        //Check to make sure a monster info singleton exists
        if(MonsterInfo.MI != null)
        {
            //set the mySelectedMonster variable
            MonsterInfo.MI.mySelectedMonster = whichMonster;
            PlayerPrefs.SetInt("MyMonster", whichMonster);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
