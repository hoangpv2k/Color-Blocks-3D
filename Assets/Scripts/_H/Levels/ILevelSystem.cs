using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface ILevelSystem
{
    AllLevels AllLevels { get; }
    int NormalCurrentLevelNumber { get; }
    int HighestLevelNumber { get; }
    ILevel CurrentLevel { get; }
    bool IsLevelReady { get; }
    void SetLevelIndex_Force(int levelIndex);
    void ConfigureAndLoadLevel();
    void LevelLoaded<T>(T level, object levelRef) where T : ILevel;
    void LevelLoaded();
}
