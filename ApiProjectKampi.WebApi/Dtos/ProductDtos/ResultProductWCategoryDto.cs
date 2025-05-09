﻿using ApiProjectKampi.WebApi.Entities;

namespace ApiProjectKampi.WebApi.Dtos.ProductDtos
{
    public class ResultProductWCategoryDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
