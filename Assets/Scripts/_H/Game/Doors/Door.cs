using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private List<DoorPart> doorParts;

    [SerializeField]
    private BlocksData blocksData;

    [SerializeField]
    private LevelElementsData levelElementsData;

    [SerializeField]
    private SkinnedMeshRenderer skinnedMeshRenderer;

    [SerializeField]
    private Renderer bottomRenderer;

    [SerializeField]
    private Star starLevelElement;

    [SerializeField]
    private bool hasStar;

    public int BlockType;

    [Header("Switch")]
    [SerializeField]
    private bool switchDoor;

    [SerializeField]
    private bool isOff;

    [SerializeField]
    private SkinnedMeshRenderer metalGate;

    [Header("Ice")]
    [SerializeField]
    private bool hasIce;

    [SerializeField]
    private int iceCount;

    [SerializeField]
    private Ice iceLevelElement;

    [Header("MovingDoorLock")]
    [SerializeField]
    private bool hasMovingDoorLock;

    [SerializeField]
    private int movingDoorOrder;

    [SerializeField]
    private MovingDoorLock movingDoorLock;

    private GridManager _gridManager;

    public DoorDirection DoorDirection
    {
        get
        {
            return default(DoorDirection);
        }
        private set
        {
        }
    }

    public int Size => 0;

    public bool HasMovingDoorLock => false;

    public int MovingDoorOrder => 0;

    public bool HasIce => false;

    public int IceCount => 0;

    public bool HasStar => false;

    public bool IsSwitchDoor => false;

    public bool IsSwithcDoorOff => false;

    private int BlockTypeMax => 0;

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    public void ToggleDoorSwitch()
    {
    }

    private void SetSwitch(bool off, bool immediately)
    {
    }

    public void SetMovingDoorLock(MovingDoorLock movingDoorLock)
    {
    }

    public void RemoveMovingDoorLock()
    {
    }

    private void SetDirection()
    {
    }
    public void Open()
    {
    }

    public void Close()
    {
    }
}
