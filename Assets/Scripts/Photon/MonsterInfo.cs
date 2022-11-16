using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterInfo : MonoBehaviour
{
    public static MonsterInfo MI;
    public int mySelectedMonster;
    public GameObject [] allMonsters;
    
    void OnEnable()
    {
        if(MonsterInfo.MI == null)
        {
            MonsterInfo.MI = this;
        }

        else
        {
            //Check if the current script does not equal to the current singleton
            if(MonsterInfo.MI != this)
            {
                //Reset the singleton and set the MonsterInfo to the new this
                Destroy(MonsterInfo.MI.gameObject);
                MonsterInfo.MI = this;
            }
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        //Check if prefabs exist, if it does, set mySelectedMonster equal to this value
        if(PlayerPrefs.HasKey("MyMonster"))
        {
            mySelectedMonster = PlayerPrefs.GetInt("MyMonster");
        }
        else
        {
            mySelectedMonster = 0;
            PlayerPrefs.SetInt("MyMonster", mySelectedMonster);
        }

    }

    void Update()
    {
        
    }
}
