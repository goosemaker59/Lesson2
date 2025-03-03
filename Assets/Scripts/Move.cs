using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct VectorXYZ
{
    public float x, y, z;

    public VectorXYZ(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }

    public override string ToString()
    {
        return $"({x}, {y}, {z})";
    }

    readonly public float Vectorlength()
    {
        return Mathf.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z * this.z));
    }

    readonly public VectorXYZ Codirectional() 
    {
        float length = this.Vectorlength();
        if (this.Vectorlength() > 0)
            {
                return new VectorXYZ(this.x / length, this.y / length, z / length);
            }
        return new VectorXYZ(0, 0, 0);
    }
    readonly public float Dot(VectorXYZ other)
    {
        return this.x * other.x + this.y * other.y + this.z * other.z;
    }
    readonly public VectorXYZ Cross(VectorXYZ other)
    {
        return new VectorXYZ(
            y * other.z - z * other.y,
            z * other.x - x * other.z,
            x * other.y - y * other.x
        );
    }

}

public class Move : MonoBehaviour
{
    VectorXYZ vector = new VectorXYZ(11, 5, 3);
    VectorXYZ vector2 = new VectorXYZ(5, 2, 10);
    Vector3 vector3 = new Vector3(11,5, 3);
    Vector3 vector32 = new Vector3(5, 2, 10);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vector.Vectorlength());
        Debug.Log(vector3.magnitude);

        Debug.Log(vector.Codirectional());
        Debug.Log(vector3.normalized);

        Debug.Log(vector.Dot(vector2));
        Debug.Log(Vector3.Dot(vector3,vector32));

        Debug.Log(vector.Cross(vector2));
        Debug.Log(Vector3.Cross(vector3,vector32));
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}

