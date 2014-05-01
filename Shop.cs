using UnityEngine;
using System.Collections;

public class Shop {
	private BetterList<Outfit> outfits = new BetterList<Outfit>();

	public Shop() {

	}

	public BetterList<Outfit> GetOutfits() {
		return outfits;
	}

	public void AddOutfit(Outfit outfit) {
		outfits.Add(outfit);
	}
	
	public void RemoveOutfit(Outfit outfit) {
		outfits.Remove(outfit);
	}

	public int GetOutfitPrice(Outfit outfit) {
		return outfit.GetPrice();
	}

	public void BuyOutfit(Girl girl, Outfit outfit) {
		girl.BuyOutfit(outfit);
	}

}
