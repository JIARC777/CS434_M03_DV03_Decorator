using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Decorator: IRifle 
{
    protected IRifle decoratedRifle;

    public Decorator(IRifle rifle)
    {
        decoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return decoratedRifle.GetAccuracy();
    }
}

public class WithScope: Decorator
{
    float ScopeAccuracy = 20.0f;
    // load model based on parent position which is model
    // gameobject model
    /*
     * prefab = resource load
     */
    public WithScope(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + ScopeAccuracy;
    }
}

public class WithStabilzer : Decorator
{
    float StablizerAccuracy = 10.0f;

    public WithStabilzer(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + StablizerAccuracy;
    }
}


public class WithDotSight : Decorator
{
    float DotAccuracy = 7.5f;

    public WithDotSight(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + DotAccuracy;
    }
}

public class WithLongBarrel : Decorator
{
    float MuzzleAccuracy = 5f;

    public WithLongBarrel(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + MuzzleAccuracy;
    }
}
