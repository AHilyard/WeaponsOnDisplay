using System.Xml.Serialization;
using Netcode;
using StardewValley;
using StardewValley.Tools;

namespace WeaponsOnDisplay
{
	public class WeaponProxy : Object
	{
		private readonly NetRef<MeleeWeapon> weapon = new NetRef<MeleeWeapon>();
		public MeleeWeapon Weapon
		{
			get
			{
				return weapon.Value;
			}

			set
			{
				weapon.Value = value;
			}
		}

		public new int ParentSheetIndex
		{
			get { return weapon.Value?.ParentSheetIndex ?? 0; }
			set
			{
				if (weapon.Value != null)
				{
					weapon.Value.ParentSheetIndex = value;
				}
			}
		}

		public WeaponProxy(MeleeWeapon weapon)
		{
			this.weapon.Value = weapon;
		}

		public WeaponProxy() {}

		protected override void initNetFields()
		{
			base.initNetFields();
			base.NetFields.AddField(weapon, "weapon");
		}

		protected override Item GetOneNew()
		{
			return weapon.Value?.getOne();
		}

		public override bool performDropDownAction(Farmer who)
		{
			return false;
		}
	}
}