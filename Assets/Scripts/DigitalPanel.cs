using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DigitalPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_ArcticCurrent;
    [SerializeField] private TextMeshProUGUI m_ArcticMax;
    [SerializeField] private TextMeshProUGUI m_ArcticMin;

    [SerializeField] private TextMeshProUGUI m_AntarcticCurrent;
    [SerializeField] private TextMeshProUGUI m_AntarcticMax;
    [SerializeField] private TextMeshProUGUI m_AntarcticMin;


    public void SetArctic(float current, float max, float min)
    {
        m_ArcticCurrent.text = "Current:" + current;
        m_ArcticMax.text = "Max:" + max;
        m_ArcticMin.text = "Min:" + min;
    }

    public void SetAntarctic(float current, float max, float min)
    {
        m_AntarcticCurrent.text = "Current:" + current;
        m_AntarcticMax.text = "Max:" + max;
        m_AntarcticMin.text = "Min:" + min;
    }
}