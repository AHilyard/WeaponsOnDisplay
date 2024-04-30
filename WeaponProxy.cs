using StardewModdingAPI;
using StardewValley;
using StardewValley.Tools;

namespace WeaponsOnDisplay
{
	public class WeaponProxy : Object
	{
		public MeleeWeapon Weapon { get; set; } = null;

		public new int ParentSheetIndex
		{
			get { return Weapon?.ParentSheetIndex ?? 0; }
			set
			{
				if (Weapon != null)
				{
					Weapon.ParentSheetIndex = value;
				}
			}
		}

		public WeaponProxy(MeleeWeapon weapon)
		{
			Weapon = weapon;
		}

		public WeaponProxy() {}

		protected override Item GetOneNew()
		{
			return Weapon.getOne();
		}

		public override bool performDropDownAction(Farmer who)
		{
			return false;
		}
	}
}