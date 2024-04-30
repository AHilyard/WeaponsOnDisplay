using StardewValley;
using StardewValley.Tools;

namespace WeaponsOnDisplay
{
	public class SlingshotProxy : Object
	{
		public Slingshot Weapon { get; set; } = null;

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

		public SlingshotProxy(Slingshot weapon)
		{
			Weapon = weapon;
		}

		public SlingshotProxy() {}

		protected override Item GetOneNew()
		{
			return Weapon.getOne();
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