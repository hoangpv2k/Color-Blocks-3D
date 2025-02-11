using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/Levels/LevelData", order = 1)]
public class LevelData : BaseLevel
{
    [Serializable]
    public class LevelDataPureClass
    {
        [SerializeField]
        private Vector2Int _gridSize;

        [SerializeField]
        private List<Vector2Int> _hidedGridCoords;

        [SerializeField]
        private List<GridColorData> _gridColorDatas;

        [SerializeField]
        private LevelCameraData _levelCameraData;

        [SerializeField]
        private LevelDoorsData _levelDoorsData;

        [SerializeField]
        private LevelBlockadesData _levelBlockadesData;

        [SerializeField]
        private LevelBlockGroupsData _levelBlockGroupsData;

        [SerializeField]
        private LevelCratesData _levelCratesData;

        public Vector2Int GridSize => default(Vector2Int);

        public List<Vector2Int> HidedGridCoords => null;

        public List<GridColorData> GridColorDatas => null;

        public LevelCameraData CameraData => default(LevelCameraData);

        public LevelDoorsData Doors => null;

        public LevelBlockadesData Blockades => null;

        public LevelBlockGroupsData BlockGroupsData => null;

        public LevelCratesData LevelCratesData => null;

    }

    [Serializable]
    public struct LevelCameraData
    {
        [SerializeField]
        private Vector3 _position;

        [SerializeField]
        private Vector3 _rotation;

        [SerializeField]
        private float _fov;

        public Vector3 Position => default(Vector3);

        public Vector3 Rotation => default(Vector3);

        public float Fov => 0f;



    }

    [Serializable]
    public class LevelDoorsData
    {
        [SerializeField]
        private bool _inverseMovingDoorDirection;

        [SerializeField]
        private List<LevelDoorData> _doors;

        public bool InverseMovingDoorDirection => false;

        public List<LevelDoorData> Doors => null;
    }

    [Serializable]
    public struct LevelDoorData
    {
        [SerializeField]
        private Vector3 _position;

        [SerializeField]
        private Vector3 _rotation;

        [SerializeField]
        private int _doorPartCount;

        [SerializeField]
        private int _blockType;

        [SerializeField]
        private bool _hasStar;

        [SerializeField]
        private bool _isSwitchDoor;

        [SerializeField]
        private bool _isSwitchDoorOff;

        [SerializeField]
        private bool _hasIce;

        [SerializeField]
        private int _iceCount;

        [SerializeField]
        private bool _hasMovingDoorLock;

        [SerializeField]
        private int _movingDoorOrder;

        public Vector3 Position => default(Vector3);

        public Vector3 Rotation => default(Vector3);

        public int DoorPartCount => 0;

        public int BlockType => 0;

        public bool HasStar => false;

        public bool IsSwitchDoor => false;

        public bool IsSwitchDoorOff => false;

        public bool HasIce => false;

        public int IceCount => 0;

        public bool HasMovingDoorLock => false;

        public int MovingDoorOrder => 0;


    }

    [Serializable]
    public class LevelBlockadesData
    {
        [SerializeField]
        private List<LevelBlockadeData> _blockades;

        public List<LevelBlockadeData> Blockades => null;

    }

    [Serializable]
    public struct LevelBlockadeData
    {
        [SerializeField]
        private Vector3 _position;

        [SerializeField]
        private Vector3 _rotation;

        [SerializeField]
        private Vector3 _scale;

        [SerializeField]
        private Blockade.BlockadeType _blockType;

        [SerializeField]
        private float _blendValue;

        public Vector3 Position => default(Vector3);

        public Vector3 Rotation => default(Vector3);

        public Vector3 Scale => default(Vector3);

        public Blockade.BlockadeType BlockType => default(Blockade.BlockadeType);

        public float BlendValue => 0f;


    }

    [Serializable]
    public class LevelBlockGroupsData
    {
        [SerializeField]
        private List<LevelBlockGroupData> _blockGroupDatas;

        public List<LevelBlockGroupData> BlockGroupDatas => null;

    }

    [Serializable]
    public class LevelBlockGroupData
    {
        [SerializeField]
        private Vector3 _position;

        [SerializeField]
        private Vector3 _rotation;

        [SerializeField]
        private BlockGroupType _blockGroupType;

        [SerializeField]
        private int _blockType;

        [SerializeField]
        private bool _isOneWayMovementActive;

        [SerializeField]
        private WayDirection _wayDirection;

        [SerializeField]
        private LevelBlockGroupLevelElementData _blockGroupLevelElementData;

        [SerializeField]
        private LevelBlockGroupJoinedGroupData _joinedGroupData;

        [SerializeField]
        private LevelBlockGroupLayerData _layerData;

        [SerializeField]
        private bool _isBlocker;

        [SerializeField]
        private bool _isBlockerFixed;

        [SerializeField]
        private bool _isBlockerCounterActive;

        [SerializeField]
        private int _blockerCounter;

        public Vector3 Position => default(Vector3);

        public Vector3 Rotation => default(Vector3);

        public BlockGroupType BlockGroupType => default(BlockGroupType);

        public int BlockType => 0;

        public bool IsOneWayMovementActive => false;

        public WayDirection WayDirection => default(WayDirection);

        public LevelBlockGroupLevelElementData BlockGroupLevelElementData => null;

        public LevelBlockGroupJoinedGroupData JoinedGroupData => default(LevelBlockGroupJoinedGroupData);

        public LevelBlockGroupLayerData LayerData => default(LevelBlockGroupLayerData);

        public bool IsBlocker => false;

        public bool IsBlockerFixed => false;

        public bool IsBlockerCounterActive => false;

        public int BlockerCounter => 0;


    }

    [Serializable]
    public class LevelBlockGroupLevelElementData
    {
        [SerializeField]
        private LevelElementType _levelElementType;

        [SerializeField]
        private int _iceCount;

        [SerializeField]
        private int _lockCount;

        [SerializeField]
        private float _timerBombDuration;

        [SerializeField]
        private bool _curtainIsClosed;

        [SerializeField]
        private RopesData _ropesData;

        [SerializeField]
        private int _scissorsColorType;

        public LevelElementType LevelElementType => default(LevelElementType);

        public int IceCount => 0;

        public int LockCount => 0;

        public float TimerBombDuration => 0f;

        public bool CurtainIsClosed => false;

        public RopesData RopesData => null;

        public int ScissorsColorType => 0;


    }

    [Serializable]
    public struct LevelBlockGroupJoinedGroupData
    {
        [SerializeField]
        private bool _isMemberOfJoinedGorup;

        [SerializeField]
        private int _groupIndex;

        public bool IsMemberOfJoinedGorup => false;

        public int GroupIndex => 0;


    }

    [Serializable]
    public struct LevelBlockGroupLayerData
    {
        [SerializeField]
        private bool _hasLayer;

        [SerializeField]
        private int _blockType;

        public bool HasLayer => false;

        public int BlockType => 0;



    }

    [Serializable]
    public class LevelCratesData
    {
        [SerializeField]
        private List<LevelCrateData> _levelCrateDatas;

        public List<LevelCrateData> LevelCrateDatas => null;



    }

    [Serializable]
    public class LevelCrateData
    {
        [SerializeField]
        private Vector3 _position;

        [SerializeField]
        private Vector3 _rotation;

        [SerializeField]
        private CrateType _crateType;

        [SerializeField]
        private int _counter;

        public Vector3 Position => default(Vector3);

        public Vector3 Rotation => default(Vector3);

        public CrateType CrateType => default(CrateType);

        public int Counter => 0;

    }

    [SerializeField]
    private LevelDataPureClass _levelDataPureClass;

    public Vector2Int GridSize => default(Vector2Int);

    public List<Vector2Int> HidedGridCoords => null;

    public List<GridColorData> GridColorDatas => null;

    public LevelCameraData CameraData => default(LevelCameraData);

    public LevelDoorsData Doors => null;

    public LevelBlockadesData Blockades => null;

    public LevelBlockGroupsData BlockGroupsData => null;

    public LevelCratesData CratesData => null;

    public List<UnlockItemType> GetUnlockItemTypes()
    {
        return null;
    }
}
