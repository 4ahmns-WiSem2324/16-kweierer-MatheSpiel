using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Teilbarkeitsregeln : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI resultText;

    private void Start()
    {
        inputField.onEndEdit.AddListener(OnInputFieldEndEdit);
    }

    private void OnInputFieldEndEdit(string input)
    {
        if (int.TryParse(input, out int number))
        {
            resultText.text = "";
        }
        else
        {
            ShowInvalidInput();
        }
    }

    public void CheckDivisibilityBy2()
    {
        CheckDivisibility(2);
    }

    public void CheckDivisibilityBy3()
    {
        CheckDivisibility(3);
    }

    public void CheckDivisibilityBy5()
    {
        CheckDivisibility(5);
    }

    public void CheckDivisibilityBy7()
    {
        CheckDivisibility(7);
    }

    public void CheckDivisibilityBy9()
    {
        CheckDivisibility(9);
    }

    private void CheckDivisibility(int divisor)
    {
        if (int.TryParse(inputField.text, out int number))
        {
            if (number % divisor == 0)
            {
                ShowResult("Ja", number + " ist durch " + divisor + " teilbar.");
            }
            else
            {
                ShowResult("Nein", number + " ist nicht durch " + divisor + " teilbar.");
            }
        }
        else
        {
            ShowInvalidInput();
        }
    }

    private void ShowResult(string result, string explanation)
    {
        resultText.text = result + "\n" + explanation;
    }

    private void ShowInvalidInput()
    {
        resultText.text = "Ungültige Eingabe";
    }
}
