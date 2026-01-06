using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using HealthHub.Models.ViewModels;


namespace HealthHub.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")] 
    public class PageLinkTagHelper : TagHelper 
    {
        private IUrlHelperFactory urlHelperFactory; 
         
        public PageLinkTagHelper(IUrlHelperFactory helperFactory) 
        {
            urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext? ViewContext { get; set; } 
        public PagingInfo? PageModel { get; set; } 
        public string? PageAction { get; set; } 

        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; }
            = new Dictionary<string, object>();


       
