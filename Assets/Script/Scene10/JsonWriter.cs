using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonWriter : MonoBehaviour
{
    [System.Serializable]
    public class Stats
    {
        public string name;
        public int level;
        public int minHealth;
        public int maxHealth;
        public List<string> resists;
        public List<string> weaknesses;
    }

    public Stats orcGruntStats = new Stats();

    public void createJson()
    {
        string output = JsonUtility.ToJson(orcGruntStats);
        var path = Application.dataPath + "/text.txt";
        File.WriteAllText(path, output);
    }
}
