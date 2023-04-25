using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private List<string> enemyNames = new List<string>(); // List to store enemy names

    // Add a new enemy name to the list
    public void AddName(string enemyName)
    {
        enemyNames.Add(enemyName);
        Debug.Log($"Added {enemyName}. Now there are {enemyNames.Count} enemy names.");
    }

    // Remove the last enemy name from the list
    public void RemoveLastName()
    {
        if (enemyNames.Count > 0)
        {
            string removedName = enemyNames[enemyNames.Count - 1];
            enemyNames.RemoveAt(enemyNames.Count - 1);
            Debug.Log($"Removed {removedName}.");
        }
        else
        {
            Debug.Log("There are no enemy names to remove.");
        }
    }

    // Print out all the names from the list that start with the letter "S"
    public void PrintNamesStartingWithS()
    {
        Debug.Log("Enemy names starting with 'S':");
        foreach (string enemyName in enemyNames)
        {
            if (enemyName.StartsWith("S"))
            {
                Debug.Log(enemyName);
            }
        }
    }

    // Print the total number of enemy names in the list
    public void PrintTotalEnemyNames()
    {
        Debug.Log($"There are {enemyNames.Count} enemy names.");
    }
}
