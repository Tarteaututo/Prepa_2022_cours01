using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameManager[] gameManagers = FindObjectsOfType<GameManager>();

                if (gameManagers.Length == 0 || gameManagers.Length > 1)
                {
                    Debug.LogError("Found no or too much GameManagers, there has to be only one in scene. Aborting.");
                    return null;
                }
                instance = gameManagers[0];
            }

            return instance;
        }
    }

    public void TestGameManager()
    {
        Debug.Log("TestGameManager");
    }
}
