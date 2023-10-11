﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantBackendWebsite.Models.DTOs
{
	public class CategoryDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
	}
}