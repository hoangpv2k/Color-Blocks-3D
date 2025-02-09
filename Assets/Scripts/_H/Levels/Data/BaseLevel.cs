using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseLevel : ScriptableObject, ILevel
{
    [SerializeField] protected string id;
    public string ID => id;
}
