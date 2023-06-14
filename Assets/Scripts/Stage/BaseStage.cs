using System;



public abstract class BaseStage 
{
    public abstract void Initialize();
    public abstract void Dispose();
    public abstract eStageType GetStageType();
    public virtual void PreStageChange(){}
    public virtual void PostStageChange(){}
}