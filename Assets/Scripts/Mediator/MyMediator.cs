using PureMVC.Interfaces;
using PureMVC.Patterns.Mediator;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyMediator : Mediator
{
    #region MVC
    public const string mediatorName = "myMediator01";

    public MyMediator(GameObject root):base(mediatorName)
    {
        InitUI(root);
    }

    public override string[] ListNotificationInterests()
    {
        return new string[] { "msg_add", "msg_sub" };
    }
    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case "msg_add":
            case "msg_sub":
                Display(notification.Body as MyData);
                break;
        }
    }

    void SendCmdAdd()
    {
        SendNotification("cmd_add");
    }
    void SendCmdSub()
    {
        SendNotification("cmd_sub");
    }
    #endregion

    #region UI
    Text showText;
    void InitUI(GameObject root)
    {
        Button addBtn = root.transform.Find("ButtonAdd").GetComponent<Button>();
        addBtn.onClick.AddListener(SendCmdAdd);

        Button subBtn = root.transform.Find("ButtonSub").GetComponent<Button>();
        subBtn.onClick.AddListener(SendCmdSub);

         showText = root.transform.Find("TextShow").GetComponent<Text>();

    }
     
    void Display(MyData myData)
    {
        showText.text = myData.myValue.ToString();
    }

    #endregion
}
