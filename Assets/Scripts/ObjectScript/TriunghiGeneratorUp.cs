using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class TriunghiGeneratorUp : MonoBehaviour
{
	public GameObject triunghiPrefab; // referin?a la obiectul prefab al triunghiului
	public float distantaMinima = 1f; // distan?a minim? la care trebuie generat triunghiul sub ecran
	public float timpGenerare = 2f; // timpul între gener?rile succesive de triunghi
	public float pozitieMaximaY = -10f; // pozi?ia maxim? Y la care triunghiul trebuie s? fie distrus

	private float timpTrecut = 0f; // timpul trecut de la ultima generare a triunghiului

	public GameObject limL;
	public GameObject limR;


	void Update()
	{
		timpTrecut += Time.deltaTime; // actualizarea timpului trecut de la ultima generare

		if (timpTrecut >= timpGenerare) // verificarea dac? a trecut suficient timp pentru a genera un nou triunghi
		{
			timpTrecut = 0f; // resetarea timpului trecut

			// generarea pozi?iei random sub ecran
			float x = Random.Range(limL.transform.position.x,limR.transform.position.x); // pozi?ie x între
			float y = -Camera.main.orthographicSize - distantaMinima; // pozi?ie y la distan?a minim? sub ecran
			Vector2 pozitieGenerata = new Vector2(x, y);

			// crearea triunghiului la pozi?ia generat?
			GameObject triunghi = Instantiate(triunghiPrefab, pozitieGenerata, Quaternion.identity);
			triunghi.transform.SetParent(transform); // setarea obiectului generat ca fiind copilul obiectului acestui script
		}

		// verificarea dac? triunghiul a dep??it pozi?ia maxim? Y ?i, dac? da, îl distruge
		foreach (Transform child in transform)
		{
			if (child.position.y <= pozitieMaximaY)
			{
				Destroy(child.gameObject);
			}
		}
	}
}