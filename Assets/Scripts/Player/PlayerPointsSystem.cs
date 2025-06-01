using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class PlayerPointsSystem : MonoBehaviour
{
    // Script only variables
    float playerPoints;
    float playerXP;
    int playerLevel = 1;
    float nextXPTarget;

    // Unity Serialized variables
    [SerializeField] float LevelThreshold;
    [SerializeField] float LevelThresholdAdditive;

    void Start()
    {
        nextXPTarget = LevelThreshold;
    }

    // Finds and sets the UI to update with the player's level and XP.
    void Update()
    {
        CheckLevel();
        GameObject.Find("current xp").GetComponent<UITextSystem>().SetValue(playerLevel.ToString());
        GameObject.Find("xp to level").GetComponent<UITextSystem>().SetValue((nextXPTarget - playerXP).ToString());
    }
        
    public void AddPoints(float points)
    {
        playerPoints += points;
        playerXP += points;
    }

    void CheckLevel()
    {
        if (playerXP >= nextXPTarget)
        {
            PerformLevelUp();
        }
    }

    // Adds one to player level, sets the new XP target and resets the player's current XP. Also activates the
    // smooth scaling script.
    void PerformLevelUp()
    {
        playerLevel += 1;
        nextXPTarget += LevelThresholdAdditive;
        playerXP = 0;
        gameObject.GetComponent<SmoothScalingSystem>().SmoothAddValueToScale(10f);
    }
}
