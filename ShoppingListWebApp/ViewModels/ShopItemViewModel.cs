﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ShoppingListWebApp.ViewModels
{
    public class ShopItemViewModel
    {
        public long Id { get; init; }

        [Display(Name = "Item")]
        [Required(ErrorMessage = "Please enter a product name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Product name should be between {2} and {1} characters long")]
        public string Name { get; set; }
        
        [Range(1,5, ErrorMessage="Amount should be between {1} and {2}")]
        public int Quantity { get; set; }
        public IEnumerable<SelectListItem> QuantityList { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Please enter a {0} for this item")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Category")]
        [Range(1, int.MaxValue, ErrorMessage = "You must choose a {0}")]
        public int SelectedCategoryId { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
