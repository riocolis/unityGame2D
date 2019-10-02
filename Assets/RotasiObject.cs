using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotasiObject : MonoBehaviour
{
    public Vector3 maju, mundur;
    public int speedRotasi;
    // Start is called before the first frame update
    void Start()
    {
        maju = new Vector3 (0,0,1);
        mundur = new Vector3 (0,0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = transform.rotation * toQuaternion(mundur * speedRotasi * Time.deltaTime);
    }

    private Quaternion toQuaternion(Vector3 vector3)
    {
        Quaternion q;
        float pitch = vector3.y;
        float roll = vector3.x;
        float yaw = vector3.z;
        float t0 = Mathf.Cos(yaw * 0.5f);
        float t1 = Mathf.Sin(yaw * 0.5f);
        float t2 = Mathf.Cos(roll * 0.5f);
        float t3 = Mathf.Sin(roll * 0.5f);
        float t4 = Mathf.Cos(pitch * 0.5f);
        float t5 = Mathf.Sin(pitch * 0.5f);
        Debug.Log(t0+" "+t1+" "+t2+" "+t3+" "+t4+" "+t5+" ");
        q.x = t0 * t3 * t4 - t1 * t2 * t5;
        q.y = t0 * t2 * t5 + t1 * t3 * t4;
        q.z = t1 * t2 * t4 - t0 * t3 * t5;
        q.w = t0 * t2 * t4 + t1 * t3 * t5;
        return q;
    }
}
