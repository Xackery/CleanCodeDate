using UnityEngine;
using System.Collections;

public class Outfit {
	private int id;
	private bool isWorn;
	private int price;
	private BetterList<OutfitSlot> slots = new BetterList<OutfitSlot>();
	public Outfit() {
		
	}

	public int GetID() {
		return id;
	}

	public void SetID(int id) {
		this.id = id;
	}

	public void SetWorn(bool worn) {
		isWorn = worn;
	}

	public bool isCurrentlyBeingWorn() {
		return isWorn;
	}
	
	public void SetCurrentlyBeingWorn(bool worn) {
		isWorn = worn;
	}

	public void SetPrice(int money) {
		price = money;
	}

	public int GetPrice() {
		return price;
	}

	public bool isUsingSlot(OutfitSlot outfitSlot) {
		return (slots.Contains(outfitSlot));
	}

	public void AddOutfitSlot(OutfitSlot outfitSlot) {
		if (!slots.Contains(outfitSlot)) slots.Add(outfitSlot);
	}

	public void RemoveOutfitSlot(OutfitSlot outfitSlot) {
		if (slots.Contains(outfitSlot)) slots.Remove(outfitSlot);
	}

	public BetterList<OutfitSlot> GetOutfitSlots() {
		return slots;
	}
}

public enum OutfitSlot {
	HeadUpper,
	EarL,
	EarR,
	Neck,
	EyesUpper,
	EyesLower,
	BodyL,
	BodyR,
	HandL,
	HandR,
	Legs,
	Feet,
}