using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStartMenu : MonoBehaviour
{
    [SerializeField] private Image characterSprite;
    [SerializeField] private InputField InputField;
    [SerializeField] private GameObject information;
    [SerializeField] private GameObject selectCharacter;

    private CharacterType characterType;
    public void OnclickCharacter()
    {
        information.SetActive(false);
        selectCharacter.SetActive(true);
    }

    public void OnclickSelectCharacter(int idx)
    {
        characterType = (CharacterType)idx;
        var character = GameManager.Instance.characterList.Find(item => item.Charactertype == characterType);
        characterSprite.sprite = character.CharacterSprite;
        characterSprite.SetNativeSize();

        selectCharacter.SetActive(false);
        information.SetActive(true);
    }

    public void OnClickJoin()
    {
        if(!(2< InputField.text.Length && InputField.text.Length < 10))
        {
            return;
        }

        GameManager.Instance.SetCharacter(characterType, InputField.text);

        Destroy(gameObject);
    }
}
