using System.IO;
using UnityEngine;


public class SaveAndLoad : MonoBehaviour
{
    [SerializeField] private SetVolume VolumeController;
    public class SaveObject
    {
        public float volume;
    }

    public void Save()
    {
        SaveObject saveobject = new SaveObject();
        saveobject.volume = VolumeController.volume_slider.value;
        string json = JsonUtility.ToJson(saveobject);
        File.WriteAllText(Application.persistentDataPath + "/Save.json", json);
        print("Saved");
    }


    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/Save.json"))
        {
            string json = File.ReadAllText(Application.persistentDataPath + "/Save.json");
            SaveObject loadedsave = JsonUtility.FromJson<SaveObject>(json);
            VolumeController.volume_slider.value = loadedsave.volume;
            print("Loaded");
        }
        else
        {
            VolumeController.volume_slider.value = 0;
            print("Not Found");
        }
    }
}
