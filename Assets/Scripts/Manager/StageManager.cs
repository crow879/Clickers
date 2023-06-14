using System;
using System.Collections.Generic;
using StageDictionary = System.Collections.Generic.Dictionary<eStageType, BaseStage>;

public enum eStageType
{
    eStart,
    eTitle, 
    eGame,
}

public class StageManager:SingletonBase<StageManager>
{
    BaseStage _currentStage = null;
    StageDictionary _stages = new StageDictionary();

    private StageManager(){}

}