using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
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
        GameObject.Find("current xp").GetComponent<UITextSystem>().SetValue(playerXP.ToString());
        GameObject.Find("xp to level").GetComponent<UITextSystem>().SetValue((nextXPTarget - playerXP).ToString());
    }
        
    public void AddPoints(float points)
    {
        playerPoints += points;
        playerXP += points;
        //print("DEBUG: Detection Stage 3: Points Added:" + points);
    }

    void CheckLevel()
    {
        if (playerXP >= nextXPTarget)
        {
            PerformLevelUp();
            //print("DEBUG: Level Up Performed");
        }
    }

    void PerformLevelUp()
    {
        playerLevel += 1;
        nextXPTarget += LevelThresholdAdditive;
        playerXP = 0;
        gameObject.GetComponent<SmoothScalingSystem>().SmoothAddValueToScale(10f);
    }
}
