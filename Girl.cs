using UnityEngine;
using System.Collections;

public class Girl {
	private int moneyInWallet;
	private string name;
	private GirlCloset girlCloset = new GirlCloset();
	private GirlFeatures girlFeatures = new GirlFeatures();
	private Boyfriend boyfriend = new Boyfriend();

	public Girl() {
	}

	public int GetMoneyInWallet() {
		return moneyInWallet;
	}

	public void SetMoneyInWallet(int money) {
		moneyInWallet = money;
	}

	public void AddMoneyToWallet(int money) {
		moneyInWallet += money;
	}

	public void SubtractMoneyFromWallet(int money) {
		moneyInWallet -= money;
	}
	
	public string GetName() {
		return this.name;
	}

	public void SetName(string name) {
		this.name = name;
	}

	public void SetSkinColor(Skin skin) {
		girlFeatures.SetSkinColor(skin);
	}

	public Skin GetSkinColor() {
		return girlFeatures.GetSkinColor();
	}

	public void SetHairStyle(HairStyle hairStyle) {
		girlFeatures.SetHairStyle(hairStyle);
	}

	public HairStyle GetHairStyle() {
		return girlFeatures.GetHairStyle();
	}

	public BetterList<Outfit> GetCurrentlyWornOutfit() {
		return girlCloset.GetWornOutfit();
	}

	public void BuyOutfit(Outfit outfit) {
		SubtractMoneyFromWallet(outfit.GetPrice());
		girlCloset.AddOutfit(outfit);
	}

}
