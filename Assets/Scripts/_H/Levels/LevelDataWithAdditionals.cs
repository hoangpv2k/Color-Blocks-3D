using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class LevelDataWithAdditionals : MonoBehaviour
{
    [SerializeField] private string _levelID;
    [SerializeField] private float _duration;
    [SerializeField] private float _minDuration;
    [SerializeField] private int _hardness;
    public string LevelID => _levelID;
    public float Duration => _duration;
    public float MinDuration => _minDuration;
    public int Hardness => _hardness;
    public LevelDataWithAdditionals(string levelID, float duration, float minDuration, int hardness)
    {
        _levelID = levelID;
        _duration = duration;
        _minDuration = minDuration;
        _hardness = hardness;
    }

}
