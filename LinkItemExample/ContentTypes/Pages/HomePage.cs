using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Labs.LinkItemProperty;
using EPiServer.SpecializedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LinkItemExample.ContentTypes.Pages
{
    [ContentType(DisplayName = "HomePage", GUID = "a8824358-659d-430a-867c-899c921c8fec", Description = "")]
    public class HomePage : PageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */

        [LinkItemProperty]
        public virtual LinkItemCollection UseLinkCollectionAsModel { get; set; }


        [LinkItemProperty]
        [BackingType(typeof(PropertyLinkCollection))]
        public virtual LinkItem UseLinkItemAsModel
        {
            get => this.GetLinkItemPropertyValue(nameof(UseLinkItemAsModel));
            set => this.SetLinkItemPropertyValue(nameof(UseLinkItemAsModel), value);
        }
    }
}
