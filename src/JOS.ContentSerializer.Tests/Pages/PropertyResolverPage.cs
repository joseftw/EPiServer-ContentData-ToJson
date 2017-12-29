﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using JOS.ContentSerializer.Attributes;

namespace JOS.ContentSerializer.Tests.Pages
{
    public class PropertyResolverPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading")]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Description")]
        public virtual string Description { get; set; }

        [CultureSpecific]
        [Display(Name = "Age")]
        public virtual int Age { get; set; }

        [CultureSpecific]
        [Display(Name = "Starting")]
        public virtual DateTime Starting { get; set; }

        [CultureSpecific]
        [Display(Name = "Private")]
        public virtual bool Private { get; set; }

        [CultureSpecific]
        [Display(Name = "Degrees")]
        public virtual double Degrees { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body")]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Main Content Area")]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(Name = "Main Video")]
        public virtual VideoBlock MainVideo { get; set; }

        [Display(Name = "Author")]
        [ContentSerializerIgnore]
        public virtual string Author { get; set; }

        public virtual string Phone
        {
            get; set;
        }

        [ContentSerializerInclude]
        public virtual string Include { get; set; }
    }
}
