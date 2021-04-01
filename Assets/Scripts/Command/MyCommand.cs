using PureMVC.Interfaces;
using PureMVC.Patterns.Command;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCommandAdd : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        MyDataProxy myDataProxy = Facade.RetrieveProxy("MyData01")as MyDataProxy;
        myDataProxy.Add();
    }
}

public class MyCommandSub : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        MyDataProxy myDataProxy = Facade.RetrieveProxy("MyData01") as MyDataProxy;
        myDataProxy.Sub();
    }
}
