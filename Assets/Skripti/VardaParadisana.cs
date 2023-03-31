using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	private string teksts;
	private string[] varianti = {"Sveiks ", "Jauku dienu ", "Prieks tevi redzēt ", "Uzredzēšanos "};

	int nejausais;

	public GameObject ievadesLauks;
	public GameObject tesktaAttelosana;
	
	public void UzglabatTekstu()
	{
		nejausais = Random.Range(0, varianti.Length); //0 - smallest possible, varianti.length - largest possible
		teksts = ievadesLauks.GetComponent<Text>().text;
        tesktaAttelosana.GetComponent<Text> ().text = varianti[nejausais]+teksts.ToUpper()+"!";

    }
}
