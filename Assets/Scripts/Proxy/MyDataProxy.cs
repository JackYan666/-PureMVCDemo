using PureMVC.Patterns.Proxy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDataProxy : Proxy
{
    public const string proxyName = "MyData01";
    private MyData myData = null;
    public MyDataProxy() : base(proxyName)
    {
        myData = new MyData();
    }

    public void Add()
    {
        myData.myValue++;

        SendNotification("msg_add", myData);
    }
    public void Sub()
    {
        myData.myValue--;
        SendNotification("msg_sub", myData);
    }
}
