using System.IO;
using UnityEngine;

public class BoxTransformSaver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.position = new Vector3(
        //    PlayerPrefs.GetFloat("BoxPos_x"), 
        //    PlayerPrefs.GetFloat("BoxPos_y"), 
        //    PlayerPrefs.GetFloat("BoxPos_z"));
        //var pos = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("BoxPos"));
        var str = File.ReadAllText(Path.Combine(Application.persistentDataPath, "save.json"));
        var pos = JsonUtility.FromJson<Vector3>(str);
        transform.position = pos;
    }


    private void OnApplicationQuit()
    {
        //PlayerPrefs.SetString("BoxPos", $"x:{transform.position.x}, y:{transform.position.y}, z:{transform.position.z}");
        var serializedString = JsonUtility.ToJson(transform.position);
        print(serializedString);
        PlayerPrefs.SetString("BoxPos", serializedString);
        //PlayerPrefs.SetFloat("BoxPos_x", transform.position.x);
        //PlayerPrefs.SetFloat("BoxPos_y", transform.position.y);
        //PlayerPrefs.SetFloat("BoxPos_z", transform.position.z);

        File.WriteAllText(Path.Combine(Application.persistentDataPath, "save.json"), serializedString);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
