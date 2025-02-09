using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class RopeData : MonoBehaviour
{
    [SerializeField]
    private int _ropeIndex;

    [SerializeField]
    private int _colorType;

    public int RopeIndex => 0;

    public int ColorType => 0;

    public RopeData(int ropeIndex, int colorType)
    {
    }
}
