using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelElementsData", menuName = "ScriptableObjects/Levels/LevelElementsData", order = 1)]
public class LevelElementsData : ScriptableObject
{
    public Material iceMaterial;
    public List<LevelElementData> datas;
}
