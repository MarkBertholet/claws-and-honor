using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{


    public int XP;
    public int currentLevel;

    void Update()
    {
        UpdateXp(5);
    }

    public void UpdateXp(int xp)
    {
        XP += xp;

        int curlvl = (int)(0.1f * Mathf.Sqrt(XP));
        if (curlvl != currentLevel)
        {
            currentLevel = curlvl;
            //add text show new level

        }

        int xpnextlevel = 100 * (currentLevel + 1) * (currentLevel + 1);
        int differencexp = xpnextlevel - XP;

        int totaldifference = xpnextlevel - (100 * currentLevel * currentLevel);

        //for gui do //diffencexp / totaldifference;
    }

}
