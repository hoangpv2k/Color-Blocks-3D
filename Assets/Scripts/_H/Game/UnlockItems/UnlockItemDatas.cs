using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnlockItemDatas", menuName = "ScriptableObject/UnlockItemDatas")]
public class UnlockItemDatas : ScriptableObject
{
    [SerializeField]
    private List<UnlockItem> unlockItems;

    public List<UnlockItem> UnlockItems => null;
}