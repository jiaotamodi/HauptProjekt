using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genFlower : MonoBehaviour
{
    public Material textureAtlas;
    public static int maxHeight = 10;
    public GameObject player;
    private Vector3 sproutPosition;
    private GameObject[] cubes;

    public void Start()
    {
        sproutPosition = this.transform.position;
        generateFlower(sproutPosition);
    }
    private void generateFlower(Vector3 pos)
    {
        cubes = new GameObject[8];
        for (int i = 0; i < 4; i++)
        {
            cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubes[i].transform.parent = this.transform;
            cubes[i].transform.position = new Vector3(pos.x, pos.y + i, pos.z);

        }
    }
    


}
