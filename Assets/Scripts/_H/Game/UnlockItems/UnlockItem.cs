using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "UnlockItem", menuName = "ScriptableObject/UnlockItem")]
public class UnlockItem : ScriptableObject
{
    public UnlockItemType UnlockItemType;

    public string Id;

    public string Name;

    public Sprite Sprite;

    public string Description;
}