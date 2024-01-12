using FreeSql.DatabaseModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace Model {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = false)]
	public partial class FsDatabase {

		[JsonProperty, Column(IsPrimary = true, IsIdentity = true)]
		public int Id { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string DatabaseName { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string DBType { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string ConnectString { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string DBKey { get; set; }

		[JsonProperty]
		public int State { get; set; }

	}

}
