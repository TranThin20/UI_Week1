using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UI;

public class MenuUser : MonoBehaviour
{
    public Image menuUser;
    public Text currentUser;
    public Text editUserName;
    public InputField inputField;
    private string saveUserName;
    public Image currentAvatar;
    public Image editAvatar;
/*    public GameObject mainUser;
    public GameObject editUser;*/
    //public Button edit;

    private void Start()
    {
        inputField.text =  editUserName.text;
        currentUser.text = PlayerPrefs.GetString(saveUserName);
        
    }

    public void ClickUser()
    {
        menuUser.gameObject.SetActive(true);
    }
    public void ClickCancel()
    {
        menuUser.gameObject.SetActive(false);
    }
    public void InputUserName()
    {
        inputField.gameObject.SetActive(true);
    }
    public void ClickOk()
    {
        //currentUser.text = saveUserName;
        editUserName.text = inputField.text;
        saveUserName = editUserName.text;
        UpdateUserName();
        Debug.Log(currentUser.text);
        inputField.gameObject.SetActive(false);
    }
    void UpdateUserName()
    {
        PlayerPrefs.SetString(saveUserName, editUserName.text);
        PlayerPrefs.Save();
        //currentUser.text = saveUserName;
    }
    public void ClickAvatar(GameObject avatar)
    {
        currentUser.text = avatar.gameObject.GetComponentInChildren<Text>().text;
        currentAvatar.sprite = avatar.gameObject.GetComponent<Image>().sprite;
        Debug.Log(currentUser.text);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
