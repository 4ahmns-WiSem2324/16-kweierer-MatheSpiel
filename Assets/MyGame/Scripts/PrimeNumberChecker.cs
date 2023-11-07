using UnityEngine;
using TMPro;

public class PrimeNumberChecker : MonoBehaviour
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
            CheckPrimeNumber(number);
        }
        else
        {
            ShowInvalidInput();
        }
    }

    private void CheckPrimeNumber(int number)
    {
        if (number <= 1)
        {
            ShowResult("Keine Primzahl", "Primzahlen sind natürliche Zahlen größer als 1.");
        }
        else
        {
            bool isPrime = true;

            for (int i = 2; i <= Mathf.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    ShowResult("Keine Primzahl", number + " ist teilbar durch " + i + ", daher ist es keine Primzahl.");
                    break;
                }
            }

            if (isPrime)
            {
                ShowResult("Primzahl", number + " ist eine Primzahl. Eine Primzahl hat genau zwei positive Teiler: 1 und sie selbst.");
            }
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

    public void ClearResult()
    {
        resultText.text = "Diese Zahl ist eine: ";
        inputField.text = "";
    }
}

