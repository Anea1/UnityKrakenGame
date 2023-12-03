using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public Vector3 position;
    public float playerHealth;
    public int playerLevel;
    public string playerName;
    public int experiencePoints;
    public List<string> inventoryItems;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);
    }
    void Start()
    {

    }

    private void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayerData();
        if (data != null)
        {
            transform.position = data.position;
            playerHealth = data.playerHealth;
            playerLevel = data.playerLevel;
            playerName = data.playerName;
            experiencePoints = data.experiencePoints;
            inventoryItems = data.inventoryItems;

        }
    }

    public void HitEnemy()
    {
        LoadPlayer();
    }
 
}