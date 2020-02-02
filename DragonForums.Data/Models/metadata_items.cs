using System;

namespace DragonForums.Data.Models
{
    public class metadata_items
    {
		public int id { get; set; }
		public int library_section_id { get; set; }
		public int parent_id { get; set; }
		public int metadata_type { get; set; }
		public String guid { get; set; }
		public int media_item_count { get; set; }
		public String title { get; set; }
		public String title_sort { get; set; }
		public String original_title { get; set; }
		public String studio { get; set; }
		public float rating { get; set; }
		public int rating_count { get; set; }
		public String tagline { get; set; }
		public String summary { get; set; }
		public String triva { get; set; }
		public String quotes { get; set; }
		public String content_rating { get; set; }
		public int content_rating_age { get; set; }
		public int index { get; set; }
		public int absolute_index { get; set; }
		public int duration { get; set; }
		public String user_thumb_url { get; set; }
		public String user_art_url { get; set; }
		public String user_banner_url { get; set; }
		public String user_music_url { get; set; }
		public String user_fields { get; set; }
		public String tags_genre { get; set; }
		public String tags_collection { get; set; }
		public String tags_director { get; set; }
		public String tags_writer { get; set; }
		public String tags_star { get; set; }
		public String originally_available_at { get; set; }
		public String available_at { get; set; }
		public String expires_at { get; set; }
		public String refreshed_at { get; set; }
		public int year { get; set; }
		public String added_at { get; set; }
		public String created_at { get; set; }
		public String updated_at { get; set; }
		public String deleted_at { get; set; }
		public String tags_counrty { get; set; }
		public String extra_data { get; set; }
		public String hash { get; set; }
		public float audience_rating { get; set; }
		public int changed_at { get; set; }
		public int resources_changed_at { get; set; }
		public int remote { get; set; }
	}
}
