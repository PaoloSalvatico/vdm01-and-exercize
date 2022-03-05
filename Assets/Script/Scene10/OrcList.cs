using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcList : MonoBehaviour
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

    public Stats orcgrunt;
    public Stats orcWizard;
    public Stats orcWarlord;
}