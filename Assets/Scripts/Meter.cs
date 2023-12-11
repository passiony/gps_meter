using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meter : MonoBehaviour
{
    public Transform ZhiZhen1;
    public Vector2 m_AnglesRange1;
    public Vector2 m_RealRange1;

    public Transform ZhiZhen2;
    public Vector2 m_AnglesRange2;
    public Vector2 m_RealRange2;

    public float angle1;
    public float angle2;

    void Start()
    {
    }

    void Update()
    {
        float t1 = angle1 / (m_AnglesRange1.y - m_AnglesRange1.x);
        float real1 = Mathf.Lerp(m_RealRange1.x, m_RealRange1.y, t1);
        ZhiZhen1.localEulerAngles = new Vector3(real1, 0, 0);

        float t2 = angle2 / (m_AnglesRange2.y - m_AnglesRange2.x);
        float real2 = Mathf.Lerp(m_RealRange2.x, m_RealRange2.y, t2);
        ZhiZhen2.localEulerAngles = new Vector3(real2, 0, 0);
    }
}