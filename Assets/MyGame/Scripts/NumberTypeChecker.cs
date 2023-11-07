using UnityEngine;
using TMPro;

public class NumberTypeChecker : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI resultText;

    [SerializeField] GameObject quizObject;

    private void Start()
    {
        inputField.onEndEdit.AddListener(OnInputFieldEndEdit);
    }

    private void OnInputFieldEndEdit(string input)
    {
        if (float.TryParse(input, out float number))
        {
            CheckNumberType(number);
        }
        else
        {
            ShowInvalidInput();
        }
    }

    private void CheckNumberType(float number)
    {
        if (number % 1 == 0)
        {
            if (number >= 0)
            {
                ShowResult("Ganze Zahl");
            }
            else
            {
                ShowResult("Negative ganze Zahl");
            }
        }
        else if (number > 0)
        {
            ShowResult("Positive Gleitkommazahl");
        }
        else
        {
            ShowResult("Negative Gleitkommazahl");
        }
    }

    private void ShowResult(string type)
    {
        resultText.text = "Diese Zahl ist eine: " + type;
    }

    private void ShowInvalidInput()
    {
        resultText.text = "Ungültige Eingabe";
    }

    public void ClearResult()
    {
        resultText.text = "Diese Zahl ist eine: ";
        inputField.text = "";
    }

    public void QuizButton()
    {
        gameObject.SetActive(false);
        quizObject.SetActive(true);
    }

    public void ExitQuiz()
    {
        gameObject.SetActive(true);
        quizObject.SetActive(false);
    }
}
