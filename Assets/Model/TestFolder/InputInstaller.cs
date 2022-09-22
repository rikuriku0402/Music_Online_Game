using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class InputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<IInputProbider>()
            .To<NormalInputProvider>()
            .AsCached();
    }
}
