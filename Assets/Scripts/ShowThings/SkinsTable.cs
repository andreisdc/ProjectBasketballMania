using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SkinsTable : MonoBehaviour
{
	public List<Button> ListOfButtons;
	public Sprite LockItem;
	public List<Image> ListOfSkins;
	private List<Image> ListOfPlayerSkins;
	public List<TMP_Text> ListOfPrice;
	public TMP_Text PlayerMoney;
	public GameObject PanelBuySkin;



	public Button ButtonBack;
	public Button ButtonLeft;
	public Button ButtonRight;

	public Button ButtonTake;
	public Button ButtonClose;

	public TMP_Text Info;
	public TMP_Text HowMuchText;
	public TMP_Text HowMuchNeedText;
	public TMP_Text Price;



	void Start()
	{
		
		PanelBuySkin.SetActive(false);
		ListOfPlayerSkins = ListOfSkins;
		PlayerMoney.text = Player.instacne.GetMoney().ToString();
		ButtonClose.onClick.AddListener(()=> CloseButton());
		for (int i = 0; i < ListOfButtons.Count; i++)
		{
			int buttonIndex = i; 
			ListOfButtons[i].onClick.AddListener(() => ButtonClicked(buttonIndex));
			ListOfPrice[i].text = " ";
		}


		for (int i = 0; i < ListOfButtons.Count; i++)
		{
			int buttonIndex = i;
			if (Player.instacne.listOfSkins[buttonIndex] == false)
			{
				ListOfPlayerSkins[buttonIndex].sprite = LockItem;
				if (buttonIndex <= 8)
				{
					ListOfPrice[buttonIndex].text = "100";
				} else if (buttonIndex <= 17)
				{
					ListOfPrice[buttonIndex].text = "500";
				}
				else if (buttonIndex <= 26)
				{
					ListOfPrice[buttonIndex].text = "1000";
				}
			}
		}
	}

	void ButtonClicked(int buttonIndex)
	{
		if (Player.instacne.listOfSkins[buttonIndex] == true)
		{
			FindObjectOfType<ChangeSkin>().SetProfilePicture(ListOfSkins[buttonIndex].sprite);
			SceneManager.LoadScene("MainMenu");
		}
		else
		{
			
			if (buttonIndex <= 8)
			{
				if (100 > Player.instacne.GetMoney())
				{
					Info.text = "Not enough money";
					HowMuchText.text = "You need:";
					Price.text = "100";
					HowMuchNeedText.text = (100 - Player.instacne.GetMoney()).ToString();
					ButtonTake.GameObject().SetActive(false);
					
				}
				else
				{
					ButtonTake.onClick.AddListener(() => AddSkin(buttonIndex));
					ButtonTake.GameObject().SetActive(true);
					Info.text = "Are you sure?";
					HowMuchText.text = " ";
					HowMuchNeedText.text = " ";
					Price.text = "100";
					
					Player.instacne.AddSkin(buttonIndex);

				}
				PanelBuySkin.SetActive(true);
				ButtonBack.interactable = false;
				ButtonLeft.interactable = false;
				ButtonRight.interactable = false;


			}
			else if (buttonIndex <= 17)
			{
				if (500 > Player.instacne.GetMoney())
				{
					Info.text = "Not enough money";
					HowMuchText.text = "You need:";
					Price.text = "500";
					HowMuchNeedText.text = (500 - Player.instacne.GetMoney()).ToString();
					ButtonTake.GameObject().SetActive(false);
				}
				else
				{
					ButtonTake.onClick.AddListener(() => AddSkin(buttonIndex));
					ButtonTake.GameObject().SetActive(true);
					Info.text = "Are you sure?";
					HowMuchText.text = " ";
					HowMuchNeedText.text = " ";
					Price.text = "500";
				}
				PanelBuySkin.SetActive(true);
				ButtonBack.interactable = false;
				ButtonLeft.interactable = false;
				ButtonRight.interactable = false;

			}
			else if (buttonIndex <= 26)
			{
				if (500 > Player.instacne.GetMoney())
				{
					Info.text = "Not enough money";
					HowMuchText.text = "You need:";
					Price.text = "1000";
					HowMuchNeedText.text = (1000 - Player.instacne.GetMoney()).ToString();
					ButtonTake.GameObject().SetActive(false);
				}
				else
				{
					ButtonTake.onClick.AddListener(() => AddSkin(buttonIndex));
					ButtonTake.GameObject().SetActive(true);
					Info.text = "Are you sure?";
					HowMuchText.text = " ";
					HowMuchNeedText.text = " ";
					Price.text = "1000";
				}
				PanelBuySkin.SetActive(true);
				ButtonBack.interactable = false;
				ButtonLeft.interactable = false;
				ButtonRight.interactable = false;

			}
		}
	}

	

	void AddSkin(int buttonIndex)
	{

		Player.instacne.AddSkin(buttonIndex);
		if (buttonIndex <= 8)
		{
			Player.instacne.AddMoney(-100);
		}
		else if (buttonIndex <= 17)
		{
			Player.instacne.AddMoney(-500);
		}
		else if (buttonIndex <= 26)
		{
			Player.instacne.AddMoney(-1000);
		}
		ListOfPlayerSkins[buttonIndex].sprite = ListOfSkins[buttonIndex].sprite;
		PanelBuySkin.SetActive(false);
		ButtonBack.interactable = true;
		ButtonLeft.interactable = true;
		ButtonRight.interactable = true;
		SceneManager.LoadScene("InSkins");
	}

	void CloseButton()
	{
		PanelBuySkin.SetActive(false);
		ButtonBack.interactable = true;
		ButtonLeft.interactable = true;
		ButtonRight.interactable = true;
	}
	
}
