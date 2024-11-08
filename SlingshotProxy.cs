using System.Xml.Serialization;
using Netcode;
using StardewValley;
using StardewValley.Tools;

namespace WeaponsOnDisplay
{
	public class SlingshotProxy : Object
	{
		private readonly NetRef<Slingshot> weapon = new NetRef<Slingshot>();
		public Slingshot Weapon
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

		public SlingshotProxy(Slingshot weapon)
		{
			this.weapon.Value = weapon;
		}

		public SlingshotProxy() {}

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

		public override void performRemoveAction()
		{
			// Do nothing.
		}
	}
}