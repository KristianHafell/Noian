using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{

    [SerializeField]
    private InputField inputField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hideInputField();
    }

    // Update is called once per frame
    void Update()
    {
        // if the user presses the return key
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // get the text from the input field
            string text = inputField.text;
            Debug.Log(text);
            hideInputField();
        }

        // if the user presses the escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            hideInputField();
        }

        // if the user presses the e key for selesting the input field
        if (Input.GetKeyDown(KeyCode.E) && inputField.transform.position.y == -700)
        {
           showInputField();
        }
    }

    void hideInputField()
    {
        inputField.DeactivateInputField();
        inputField.transform.position = new Vector3(1280, -700, 0);
    }

    void showInputField()
    {
        inputField.text = "";
        inputField.ActivateInputField();
        inputField.transform.position = new Vector3(1280, 186, 0);
    }
}
