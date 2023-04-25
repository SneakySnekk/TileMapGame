using UnityEngine;

public class CubeFieldGenerator : MonoBehaviour
{
    public GameObject cubePrefab; // Prefab of the cube to instantiate
    public float spacing = 10f; // Spacing between cubes
    public int rows = 8; // Number of rows in the field
    public int columns = 8; // Number of columns in the field

    void Start()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                // Calculate the position of the cube
                Vector3 position = new Vector3(col * spacing, 0f, row * spacing);
                
                // Instantiate a cube at the calculated position
                Instantiate(cubePrefab, position, Quaternion.identity);
            }
        }
    }
}