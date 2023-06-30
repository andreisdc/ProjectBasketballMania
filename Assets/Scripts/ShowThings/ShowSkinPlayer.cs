using UnityEngine;

namespace Assets.Scripts.ShowThings
{
	public class ShowSkinPlayer : MonoBehaviour
	{
		// Start is called before the first frame update
		void Start()
		{
			PlayerDTO.instance.SetSkin(Player.instacne.GetSkin());
		}

		// Update is called once per frame
		void Update()
		{
		}
	}
}
