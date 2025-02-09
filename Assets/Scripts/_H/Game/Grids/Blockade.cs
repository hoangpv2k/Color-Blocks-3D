using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockade : MonoBehaviour
{
    public enum BlockadeType
    {
        Side = 0,
        First = 1,
        Second = 2,
        Third = 3
    }

    [SerializeField]
    private Renderer _renderer;

    [SerializeField]
    private BlockadeType _blockadeType;

    public BlockadeType Type => default(BlockadeType);
}
