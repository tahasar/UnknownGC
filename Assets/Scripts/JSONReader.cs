using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset textJSON;

    [System.Serializable]

    public class Player{
        public string name;
        public int health;
        public int damage;
    }

    [System.Serializable]
    public class PlayerList{
        public Player[] player;
    }

    public PlayerList myPlayerList = new PlayerList();

    void OnValidate()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(textJSON.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
