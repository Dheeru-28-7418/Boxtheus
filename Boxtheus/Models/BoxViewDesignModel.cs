using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace Boxtheus.Models
{
    public class BoxViewDesignModel
    {
        public List<BoxView>? BoxViews { get; set; }
        public SelectList? Design { get; set; }
        public string? BoxDesign { get; set; }
        public string? SearchString { get; set; }
    }
}
