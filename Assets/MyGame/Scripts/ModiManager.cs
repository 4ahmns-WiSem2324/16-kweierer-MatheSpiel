using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModiManager : MonoBehaviour
{

    [SerializeField] GameObject Modi1;
    [SerializeField] GameObject Modi2;
    [SerializeField] GameObject Modi3;
    [SerializeField] GameObject Modi4;

    [SerializeField] GameObject Menu;

    private void Awake()
    {
        Menu.SetActive(true);

        Modi1.SetActive(false);
        Modi2.SetActive(false);
        Modi3.SetActive(false);
        Modi4.SetActive(false);
    }

    public void StartModi1()
    {
        Menu.SetActive(false);

        Modi1.SetActive(true);
        Modi2.SetActive(false);
        Modi3.SetActive(false);
        Modi4.SetActive(false);
    }

    public void StartModi2()
    {
        Menu.SetActive(false);

        Modi1.SetActive(false);
        Modi2.SetActive(true);
        Modi3.SetActive(false);
        Modi4.SetActive(false);
    }

    public void StartModi3()
    {
        Menu.SetActive(false);

        Modi1.SetActive(false);
        Modi2.SetActive(false);
        Modi3.SetActive(true);
        Modi4.SetActive(false);
    }

    public void StartModi4()
    {
        Menu.SetActive(false);

        Modi1.SetActive(false);
        Modi2.SetActive(false);
        Modi3.SetActive(false);
        Modi4.SetActive(true);
    }

    public void Back()
    {
        Menu.SetActive(true);

        Modi1.SetActive(false);
        Modi2.SetActive(false);
        Modi3.SetActive(false);
        Modi4.SetActive(false);
    }
}
