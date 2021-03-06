using SueMoreSpouses.Data.sp;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.SaveSystem;

namespace SueMoreSpouses.Data
{
	internal class SpousesBattleRecord
	{
		[SaveableProperty(1)]
		internal string Name
		{
			get;
			set;
		}

		[SaveableProperty(2)]
		internal SpousesBattleRecordSide AttackerSide
		{
			get;
			set;
		}

		[SaveableProperty(3)]
		internal SpousesBattleRecordSide DefenderSide
		{
			get;
			set;
		}

		[SaveableProperty(4)]
		internal CampaignTime CreatedTime
		{
			get;
			set;
		}

		[SaveableProperty(5)]
		internal int BattleResultIndex
		{
			get;
			set;
		}

		[SaveableProperty(6)]
		internal SpousesBattleRecordReward RecordReward
		{
			get;
			set;
		}

		public SpousesBattleRecord()
		{
			this.CreatedTime = CampaignTime.Now;
			this.Name = this.CreatedTime.ToString();
		}
	}
}
