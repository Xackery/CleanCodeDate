using UnityEngine;
using System.Collections;

public class GirlCloset {
	private BetterList<Outfit> outfits = new BetterList<Outfit>();

	public BetterList<Outfit> GetWornOutfit() {
		BetterList<Outfit> wornOutfits = new BetterList<Outfit>();
		foreach (Outfit outfit in outfits) {
			if (outfit.isCurrentlyBeingWorn()) wornOutfits.Add(outfit);
		}
		return wornOutfits;
	}

	public void AddOutfit(Outfit outfit) {
		if (isOutfitAvailableToBeWorn(outfit)) WearOutfit(outfit);
		outfits.Add(outfit);
	}

	public bool isOutfitAvailableToBeWorn(Outfit outfit) {
		foreach (OutfitSlot slot in outfit.GetOutfitSlots()) {
			if (outfit.isUsingSlot(slot)) return false;
		}
		return true;
	}

	public void RemoveOutfit(Outfit outfit) {
		outfits.Remove(outfit);
	}

		private void WearOutfit(Outfit outfit) {
			outfit.SetWorn(true);			
		}
}



