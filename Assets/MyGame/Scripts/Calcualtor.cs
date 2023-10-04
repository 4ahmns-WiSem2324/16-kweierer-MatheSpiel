using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculator : MonoBehaviour
{
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TextMeshProUGUI resultText;

    private float num1;
    private float num2;

    private enum Operation { None, Add, Subtract, Multiply, Divide }
    private Operation currentOperation = Operation.None;

    private void Start()
    {
        inputField1.onEndEdit.AddListener(OnInputField1EndEdit);
        inputField2.onEndEdit.AddListener(OnInputField2EndEdit);
    }

    private void OnInputField1EndEdit(string input)
    {
        if (float.TryParse(input, out num1))
        {
            inputField2.Select();
            inputField2.ActivateInputField();
        }
        else
        {
            inputField1.text = "Ungültige Eingabe";
        }
    }

    private void OnInputField2EndEdit(string input)
    {
        if (float.TryParse(input, out num2))
        {
            float result = 0f;
            switch (currentOperation)
            {
                case Operation.Add:
                    result = num1 + num2;
                    break;
                case Operation.Subtract:
                    result = num1 - num2;
                    break;
                case Operation.Multiply:
                    result = num1 * num2;
                    break;
                case Operation.Divide:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        resultText.text = "Division durch Null!";
                        return;
                    }
                    break;
                case Operation.None:
                    result = num2; 
                    break;
            }

            resultText.text = "Ergebnis: " + result.ToString();
        }
        else
        {
            inputField2.text = "Ungültige Eingabe";
        }
    }

    public void SetOperation(int operation)
    {
        currentOperation = (Operation)operation;
    }
}
