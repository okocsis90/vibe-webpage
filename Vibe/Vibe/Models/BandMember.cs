using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vibe.Models
{
    public class BandMember
    {
        public string FullName { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
        public string HtmlId { get; set; }

        public BandMember(string firstName, string lastName, string description, string img)
        {
            FullName = lastName + " " + firstName;
            Description = description;
            ImgPath = img;
            HtmlId = "#" + firstName + "Info";
        }
    }
}