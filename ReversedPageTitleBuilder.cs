using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Environment.Extensions;
using Orchard;
using Orchard.UI.PageTitle;
using Orchard.Settings;

namespace Lombiq.PrettyGoodBootstrapBaseTheme
{
    /// <summary>
    /// The sole purpose of this class is to reverse the current order of titles (that means, provide the 
    /// "Page title [separator] Site name" scheme as opposed to PageTitleBuilder
    /// </summary>
    /// <remarks>
    /// Inheriting from PageTitleBuilder is a no-go as none of its methods are virtual.
    /// </remarks>
    [OrchardSuppressDependency("Orchard.UI.PageTitle.PageTitleBuilder")]
    public class ReversedPageTitleBuilder : IPageTitleBuilder
    {
        private readonly IOrchardServices _orchardServices;

        private readonly List<string> _titleParts;
        private string _titleSeparator;

        public ReversedPageTitleBuilder(IOrchardServices orchardServices)
        {
            _orchardServices = orchardServices;
            _titleParts = new List<string>(5);
        }

        public void AddTitleParts(params string[] titleParts)
        {
            if (titleParts.Length > 0)
                foreach (string titlePart in titleParts)
                    if (!string.IsNullOrEmpty(titlePart))
                        _titleParts.Add(titlePart);
        }

        public void AppendTitleParts(params string[] titleParts)
        {
            if (titleParts.Length > 0)
                foreach (string titlePart in titleParts)
                    if (!string.IsNullOrEmpty(titlePart))
                        _titleParts.Insert(0, titlePart);
        }

        public string GenerateTitle()
        {
            if (_titleSeparator == null)
            {
                _titleSeparator = _orchardServices.WorkContext.CurrentSite.PageTitleSeparator;
            }

            if (_titleParts.Count != 0)
            {
                return String.Join(_titleSeparator, _titleParts.AsEnumerable().ToArray());
            }
            
            return "";
        }
    }
}