using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class SaveSystem
{
    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.data";
        FileStream file = new FileStream(path, FileMode.Create);

        SaveData data = new SaveData(player);

        formatter.Serialize(file, data);
        file.Close();
	}

    public static SaveData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.data";
           if(File.Exists(path))
           {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = new FileStream(path, FileMode.Open);

            SaveData data = formatter.Deserialize(file) as SaveData;

            file.Close();
            return data;
		   }else{
            Debug.Log("ERROR 404 FILE NOT FOUND" + path);
            return null;
		   }
    }
}
