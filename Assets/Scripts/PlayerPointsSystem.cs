using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPointsSystem : MonoBehaviour
{

    //Script only variables

    float playerPoints;
    float playerXP;
    int playerLevel = 1;
    float nextXPTarget;

    //Unity Serialized variables

    [SerializeField] float LevelThreshold;
    [SerializeField] float LevelThresholdAdditive;

    // Start is called before the first frame update
    void Start()
    {
        nextXPTarget = LevelThreshold;
    }

    // Update is called once per frame
    void Update()
    {
        CheckLevel();
    }

    public void AddPoints(float points)
    {
        playerPoints += points;
        playerXP += points;
        //print("DEBUG: Detection Stage 3: Points Added:" + points);
    }

    void CheckLevel()
    {
        if (playerPoints >= nextXPTarget)
        {
            PerformLevelUp();
            //print("DEBUG: Level Up Performed");
        }
    }

    void PerformLevelUp()
    {
        playerXP = 0;
        playerLevel += 1;
        nextXPTarget += LevelThresholdAdditive;
        print(nextXPTarget + " " + playerXP);
        // add another script which controlls player scaling
    }
}
