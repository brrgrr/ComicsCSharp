using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComicsCSharp.Models
{
    public class Comic
    {
        public int ComicId { get; private set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int? IssueNumber { get; set; }
        private static int nextId = 0;
        public int? Grade { get; set; }

        public List<SelectListItem> SelectItems { get; set; }

        public Comic()
        {
            this.ComicId = nextId;
            nextId++;
            this.SelectItems = new List<SelectListItem>()
            {
                new SelectListItem() {Value="0",Text="Mint"},
                new SelectListItem() {Value="1",Text="Fair"},
                new SelectListItem() {Value="2",Text="Poor"}
            };
        }

        public Comic(string title, int issueNumber)
        {
            this.Title = title;
            this.IssueNumber = issueNumber;
        }

    }
}
