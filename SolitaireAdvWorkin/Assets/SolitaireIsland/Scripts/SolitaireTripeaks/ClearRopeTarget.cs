using Nightingale.Localization;

namespace SolitaireTripeaks
{
	public class ClearRopeTarget : QuestTarget
	{
		public override bool IsEnable()
		{
			return AppearNodeConfig.Get().HasExtraType(ExtraType.Rope);
		}

		public override void DoQuest(QuestInfo questInfo, ScheduleData questIndex)
		{
			questInfo.CurrentCount++;
		}

		public override string GetDescription(QuestConfig Config)
		{
			LocalizationUtility localizationUtility = LocalizationUtility.Get("Localization_quest.json");
			return string.Format(localizationUtility.GetString("Clear_Rope_Count"), Config.NeedCount);
		}

		public override string GetLeftDescription(QuestConfig Config)
		{
			string @string = LocalizationUtility.Get("Localization_quest.json").GetString("Clear_Rope_Count");
			@string = @string.Replace("{0}", "|");
			return @string.Substring(0, @string.IndexOf("|")).Trim();
		}

		public override string GetRightDescription(QuestConfig Config)
		{
			string @string = LocalizationUtility.Get("Localization_quest.json").GetString("Clear_Rope_Count");
			@string = @string.Replace("{0}", "|");
			return @string.Substring(@string.IndexOf("|") + 1).Trim();
		}
	}
}
