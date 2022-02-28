using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OrcStats : MonoBehaviour
{
    public new string name;
    public int level;
    public int minHealth;
    public int maxHealth;
    public List<string> resists;
    public List<string> weaknesses;
}

[System.Serializable]
public class Wizard : OrcStats
{

}

[System.Serializable]
public class Warlord : OrcStats
{

}
