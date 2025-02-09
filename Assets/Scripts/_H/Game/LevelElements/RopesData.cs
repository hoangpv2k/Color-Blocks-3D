using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class RopesData : MonoBehaviour
{
    [SerializeField]
    private List<RopeData> _ropeDatas;

    public List<RopeData> RopeDatas => null;

    public RopesData(List<RopeData> ropeDatas)
    {
    }
}
