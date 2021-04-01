using PureMVC.Patterns.Facade;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFacade : Facade
{
    public MyFacade(GameObject root) : base("")
    {
        RegisterCommand("cmd_add", () => new MyCommandAdd());
        RegisterCommand("cmd_sub", () => new MyCommandSub());

        RegisterMediator(new MyMediator(root));
        RegisterProxy(new MyDataProxy());
    }
}
