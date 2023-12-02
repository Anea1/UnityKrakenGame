using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public static class SaveSystem
{
    public static void SavePlayerData(GameObject player)
    {
        PlayerData data = new PlayerData(player);
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
}
