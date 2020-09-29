using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityChargerRecipe
{
	public class CalamityChargerRecipe : Mod
	{
		public override void AddRecipes()
		{
			Mod calamityMod = ModLoader.GetMod("CalamityMod");
			ModRecipe recipe = new ModRecipe(this);
			if (calamityMod != null) {
				recipe.AddIngredient(calamityMod.ItemType("DraedonsFuelFactoryItem"));
				recipe.AddIngredient(calamityMod.ItemType("DraedonsChargingStation"));
				recipe.AddIngredient(calamityMod.ItemType("DubiousPlating"), 10);
				recipe.AddIngredient(calamityMod.ItemType("MysteriousCircuitry"), 10);
				recipe.SetResult(calamityMod.ItemType("ChargerTestItem"), 1);
				recipe.AddRecipe();
			}
		}
	}
}