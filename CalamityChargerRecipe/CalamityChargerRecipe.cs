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
			
			ModRecipe recipeCharger = new ModRecipe(this);
			if (calamityMod != null) {
				recipeCharger.AddTile(TileID.Anvils);
				recipeCharger.AddIngredient(calamityMod.ItemType("DraedonsFuelFactoryItem"));
				recipeCharger.AddIngredient(calamityMod.ItemType("DraedonsChargingStation"));
				recipeCharger.AddIngredient(calamityMod.ItemType("DubiousPlating"), 10);
				recipeCharger.AddIngredient(calamityMod.ItemType("MysteriousCircuitry"), 10);
				recipeCharger.SetResult(calamityMod.ItemType("ChargerTestItem"), 1);
				recipeCharger.AddRecipe();
			}
			
			ModRecipe recipeDubiousPlating = new ModRecipe(this);
			if (calamityMod != null) {
				recipeDubiousPlating.AddTile(TileID.Anvils);
				recipeDubiousPlating.AddIngredient(ItemID.Glass);
				recipeDubiousPlating.AddRecipeGroup("IronBar", 1);
				recipeDubiousPlating.SetResult(calamityMod.ItemType("DubiousPlating"), 1);
				recipeDubiousPlating.AddRecipe();
			}
			
			ModRecipe recipeMysteriousCircuitry = new ModRecipe(this);
			if (calamityMod != null) {
				recipeMysteriousCircuitry.AddTile(TileID.Anvils);
				recipeMysteriousCircuitry.AddIngredient(ItemID.Glass);
				recipeMysteriousCircuitry.AddRecipeGroup("IronBar", 1);
				recipeMysteriousCircuitry.SetResult(calamityMod.ItemType("MysteriousCircuitry"), 1);
				recipeMysteriousCircuitry.AddRecipe();
			}
		}
	}
}