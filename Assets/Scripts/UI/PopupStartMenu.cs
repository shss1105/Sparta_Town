using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStartMenu : MonoBehaviour
{
    [SerializeField] private InputField InputField;
    [SerializeField] private Text playerName;

    public void OnClickJoin()
    {
        if(!(2< InputField.text.Length && InputField.text.Length < 10))
        {
            return;
        }

        playerName.text = InputField.text;

        Destroy(gameObject);
    }
}
