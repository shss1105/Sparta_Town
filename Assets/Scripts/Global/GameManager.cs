using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum CharacterType
{
    Knight,
    Skeleton
}

[System.Serializable]
public class  Character
{
    public CharacterType Charactertype;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimationController;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Animator playerAnimator;
    public Text playerName;

    public List<Character> characterList = new List<Character>();


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void SetCharacter(CharacterType characterType, string name)
    {
        var character = GameManager.Instance.characterList.Find(item => item.Charactertype == characterType);
        playerAnimator.runtimeAnimatorController = character.AnimationController;
        playerName.text = name;
    }
}
