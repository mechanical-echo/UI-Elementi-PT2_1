using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParaditAttelu : MonoBehaviour {
    public GameObject bean;
    public GameObject teddy;
    public GameObject lady;
    public GameObject car;

	public GameObject paLabi;
	public GameObject paKreisi;

	public void paKreisiBins(){
		bean.transform.localScale = new Vector2(1, 1);
	}
    public void paLabiBins()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }
    void Start ()
    {
        bean.SetActive(false);
        teddy.SetActive(false);
        lady.SetActive(false);
        car.SetActive(false);
        paKreisi.GetComponent<Toggle>().interactable = false;
        paLabi.GetComponent<Toggle>().interactable = false;
    }

    public void bearImage(bool b)
    {
        teddy.SetActive(b);
    }
    public void beanImage(bool b)
    {
        bean.SetActive(b);
		paKreisi.GetComponent<Toggle> ().interactable = b;
		paLabi.GetComponent<Toggle> ().interactable = b;
    }
    public void ladyImage(bool b)
    {
        lady.SetActive(b);
    }
    public void carImage(bool b)
    {
        car.SetActive(b);
    }

}
