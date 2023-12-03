using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public static class SaveSystem
{
    public static void SavePlayerData(GameObject player)
    {
        PlayerData data = ExtractPlayerData(player);
        PlayerPrefs.SetString("PlayerData", JsonUtility.ToJson(data));
    }

    public static PlayerData LoadPlayerData()
    {
        string data = PlayerPrefs.GetString("PlayerData");
        if (!string.IsNullOrEmpty(data))
        {
            return JsonUtility.FromJson<PlayerData>(data);
        }
        return null;
    }
    private static PlayerData ExtractPlayerData(GameObject gameObject)
    {
       
        Player playerComponent = gameObject.GetComponent<Player>();
        if (playerComponent != null)
        {
            PlayerData data = new PlayerData();

            data.playerHealth = playerComponent.playerHealth;
            data.position = gameObject.transform.position;
            data.playerLevel = playerComponent.playerLevel;
            data.playerName = playerComponent.playerName;
            data.experiencePoints = playerComponent.experiencePoints;
            data.inventoryItems = playerComponent.inventoryItems;
            
            return data;
        }
        return null;
    }
}
