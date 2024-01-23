using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameMenu : MonoBehaviour
{

    [SerializeField] private InputField InputField;
    [SerializeField] private GameObject information;

    public void OnclickChangeName()
    {
        information.SetActive(true);
    }

    public void OnclickAccept()
    {
        if (!(2 < InputField.text.Length && InputField.text.Length < 10))
        {
            return;
        }

        GameManager.Instance.ChangeName(InputField.text);

        information.SetActive(false);
    }

}
