using System;

namespace cloudscribe.MetaWeblog.Models
{
	public struct TagStruct
	{
		public string tag_id;
		public string name;
		public int count;
		public string slug;
		public Uri html_url;
		public Uri rss_url;
	}
}
