using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPointsSystem : MonoBehaviour
{

    //Script only variables

    float playerPoints;
    int playerLevel = 1;

    //Unity Serialized variables

    [SerializeField] float LevelThreshold;
    [SerializeField] float LevelThresholdMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckLevel();
    }

    public void AddPoints(float points)
    {
        playerPoints += points;
        print("DEBUG: Detection Stage 3: Points Added:" + points);
    }

    void CheckLevel()
    {
        if (playerPoints >= LevelThreshold * (LevelThresholdMultiplier * playerLevel))
        {
            print("DEBUG Original XP Target:" + LevelThreshold * (LevelThresholdMultiplier * playerLevel) + " New XP Target:" + LevelThreshold * (LevelThresholdMultiplier * playerLevel + 1));
            PerformLevelUp();
            print("DEBUG: Level Up Performed");
        }
    }

    void PerformLevelUp()
    {
        playerLevel++;
        // add another script which controlls player scaling
    }
}
