using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustAttribution
	{
		public string adid
		{
			get;
			set;
		}

		public string network
		{
			get;
			set;
		}

		public string adgroup
		{
			get;
			set;
		}

		public string campaign
		{
			get;
			set;
		}

		public string creative
		{
			get;
			set;
		}

		public string clickLabel
		{
			get;
			set;
		}

		public string trackerName
		{
			get;
			set;
		}

		public string trackerToken
		{
			get;
			set;
		}

		public AdjustAttribution()
		{
		}

		public AdjustAttribution(string jsonString)
		{
			JSONNode jSONNode = JSON.Parse(jsonString);
			if (!(jSONNode == null))
			{
				trackerName = AdjustUtils.GetJsonString(jSONNode, AdjustUtils.KeyTrackerName);
				trackerToken = AdjustUtils.GetJsonString(jSONNode, AdjustUtils.KeyTrackerToken);
				network = AdjustUtils.GetJsonString(jSONNode, AdjustUtils.KeyNetwork);
				campaign = AdjustUtils.GetJsonString(jSONNode, AdjustUtils.KeyCampaign);
				adgroup = AdjustUtils.GetJsonString(jSONNode, AdjustUtils.KeyAdgroup);
				creative = AdjustUtils.GetJsonString(jSONNode, AdjustUtils.KeyCreative);
				clickLabel = AdjustUtils.GetJsonString(jSONNode, AdjustUtils.KeyClickLabel);
				adid = AdjustUtils.GetJsonString(jSONNode, AdjustUtils.KeyAdid);
			}
		}

		public AdjustAttribution(Dictionary<string, string> dicAttributionData)
		{
			if (dicAttributionData != null)
			{
				trackerName = AdjustUtils.TryGetValue(dicAttributionData, AdjustUtils.KeyTrackerName);
				trackerToken = AdjustUtils.TryGetValue(dicAttributionData, AdjustUtils.KeyTrackerToken);
				network = AdjustUtils.TryGetValue(dicAttributionData, AdjustUtils.KeyNetwork);
				campaign = AdjustUtils.TryGetValue(dicAttributionData, AdjustUtils.KeyCampaign);
				adgroup = AdjustUtils.TryGetValue(dicAttributionData, AdjustUtils.KeyAdgroup);
				creative = AdjustUtils.TryGetValue(dicAttributionData, AdjustUtils.KeyCreative);
				clickLabel = AdjustUtils.TryGetValue(dicAttributionData, AdjustUtils.KeyClickLabel);
				adid = AdjustUtils.TryGetValue(dicAttributionData, AdjustUtils.KeyAdid);
			}
		}
	}
}
