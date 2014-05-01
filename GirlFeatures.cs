using UnityEngine;
using System.Collections;

public class GirlFeatures {
	private Skin skinColor;
	private HairStyle hairStyle;

	public GirlFeatures() {
	}

	public Skin GetSkinColor() {
		return skinColor;
	}

	public void SetSkinColor(Skin skin) {
		skinColor = skin;
	}

	public HairStyle GetHairStyle() {
		return hairStyle;
	}

	public void SetHairStyle(HairStyle hairStyle) {
		this.hairStyle = hairStyle;
	}
}

public enum Skin {
	White1,
	White2,
	White3,
	Yellow1,
	Yellow2,
	Yellow3,
	Black1,
	Black2,
	Black3,
}

public enum HairStyle {
	Curly1,
	Wavy1,
	Straight1,
}