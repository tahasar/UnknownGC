using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    public GameObject heroPrefab;

    public GameObject OnUst;
    public GameObject OnAlt;
    public GameObject Orta;

    public GameObject OnUstEnemy;
    public GameObject OnAltEnemy;
    public GameObject OrtaEnemy;

    public List<GameObject> enemies;
    public List<GameObject> allies;

    public int currentTurnIndex;

    public int GetCurrentTurnIndex()
    {
        return currentTurnIndex;
    }

    public void SetCurrentTurnIndex(int value)
    {
        currentTurnIndex = value;
    }

    public void Start()
    {
        //AFTER NETWORK SPAWN MANAGER THIS SHOULD CARRIED TO ON SERVER CONNECT METHOD
        GameObject hero1 = Instantiate(heroPrefab, OnUst.transform.position, OnUst.transform.rotation);
        GameObject hero2 = Instantiate(heroPrefab, OnAlt.transform.position, OnAlt.transform.rotation);
        GameObject hero3 = Instantiate(heroPrefab, Orta.transform.position, Orta.transform.rotation);



        //AFTER NETWORK SPAWN MANAGER THIS SHOULD CARRIED TO ON CLIENT CONNECT METHOD
        GameObject enemyHero1 = Instantiate(heroPrefab, OnUstEnemy.transform.position, Quaternion.Inverse(OnUstEnemy.transform.rotation));
        GameObject enemyHero2 = Instantiate(heroPrefab, OnAltEnemy.transform.position, Quaternion.Inverse(OnAltEnemy.transform.rotation));
        GameObject enemyHero3 = Instantiate(heroPrefab, OrtaEnemy.transform.position, Quaternion.Inverse(OrtaEnemy.transform.rotation));
    }


}
