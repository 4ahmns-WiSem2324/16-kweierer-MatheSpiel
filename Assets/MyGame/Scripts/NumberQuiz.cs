using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberQuiz : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    public TextMeshProUGUI questionText;
    public Button yesButton;
    public Button noButton;
    public Button nextButton;

    private float currentNumber;
    private bool isNatural;

    private void Start()
    {
        GenerateQuiz();
        yesButton.onClick.AddListener(() => CheckAnswer(true));
        noButton.onClick.AddListener(() => CheckAnswer(false));
        nextButton.onClick.AddListener(GenerateQuiz);
    }

    private void GenerateQuiz()
    {
        currentNumber = Random.Range(-100f, 100f);

        SetQuestion();

        yesButton.interactable = true;
        noButton.interactable = true;
    }

    private void SetQuestion()
    {
        numberText.text = "Zahl: " + currentNumber.ToString();

        isNatural = currentNumber >= 0 && currentNumber % 1 == 0;

        questionText.text = "Ist diese Zahl eine Natürliche, Gleitkommazahl oder Ganze Zahl?";
    }

    private void CheckAnswer(bool userAnswer)
    {

        yesButton.interactable = false;
        noButton.interactable = false;


        if ((userAnswer && isNatural) || (!userAnswer && !isNatural))
        {

            questionText.text = "Richtig!";
        }
        else
        {

            questionText.text = "Falsch. Die korrekte Antwort ist: " + (isNatural ? "Natürliche Zahl" : "Gleitkommazahl oder Ganze Zahl");
        }
    }
}

