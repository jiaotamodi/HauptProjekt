using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube
{
    

        enum Cubeside { BOTTOM, TOP, LEFT, RIGHT, FRONT, BACK };
        public enum CubeType { STEM, LEAVE, PETAL };
        public CubeType cubeType;
        public bool isSolid;
        public Chunk owner;
        GameObject parent;
        public Vector3 position;

        public int health;
        public int currentHealth;

        Vector2[,] cubeUVs =
        {
       /*WATERTOTEST*/ {new Vector2(0.875f,0.125f),  new Vector2(0.9375f,0.125f),
                                 new Vector2(0.875f,0.1875f), new Vector2(0.9375f,0.1875f) }
    };
        public Cube(CubeType cubeType, Vector3 pos, GameObject gameObject, Chunk owner)
        {
            this.cubeType = cubeType;
            this.position = pos;
            this.parent = gameObject;
            this.owner = owner;
        }

        private void CreateQuad(Cubeside side)
        {
            Mesh mesh = new Mesh();
            mesh.name = "ScriptedCubeMesh" + side.ToString();

            Vector3[] vertices = new Vector3[4];
            Vector3[] normals = new Vector3[4];
            Vector2[] uvs = new Vector2[4];
            List<Vector2> suvs = new List<Vector2>();
            int[] triangles = new int[6];

            Vector2 uv00;
            Vector2 uv10;
            Vector2 uv01;
            Vector2 uv11;

            if (cubeType == CubeType.STEM)
            {
                uv00 = cubeUVs[4, 0];
                uv10 = cubeUVs[4, 1];
                uv01 = cubeUVs[4, 2];
                uv11 = cubeUVs[4, 3];

            }
        }
}
