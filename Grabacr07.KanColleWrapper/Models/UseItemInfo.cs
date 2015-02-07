﻿using Grabacr07.KanColleWrapper.Models.Raw;

namespace Grabacr07.KanColleWrapper.Models
{
	/// <summary>
	/// 消費アイテムの種類に基づく情報を表します。
	/// </summary>
	public class UseItemInfo : RawDataWrapper<kcsapi_mst_useitem>, IIdentifiable
	{
		public int Id => this.RawData.api_id;

	    public string Name => this.RawData.api_name;

	    internal UseItemInfo(kcsapi_mst_useitem rawData) : base(rawData) { }

		public override string ToString()
		{
			return string.Format("ID = {0}, Name = \"{1}\"", this.Id, this.Name);
		}
	}
}
