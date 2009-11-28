﻿namespace JavaLanguageService.Text
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.Text.Editor;
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Utilities;
    using JavaLanguageService.Text.Language;
using Microsoft.VisualStudio.Language.Intellisense;

    [Export(typeof(IWpfTextViewMarginProvider))]
    [MarginContainer(PredefinedMarginNames.Top)]
    [ContentType("text")]
    [Order(Before = PredefinedMarginNames.ZoomControl)]
    [Name("Dropdown Bar Margin")]
    [TextViewRole(PredefinedTextViewRoles.Structured)]
    public sealed class DropdownBarMarginProvider : IWpfTextViewMarginProvider
    {
        [Import]
        public ILanguageElementManagerService LanguageElementManagerService;

        [Import]
        public IGlyphService GlyphService;

        public IWpfTextViewMargin CreateMargin(IWpfTextViewHost wpfTextViewHost, IWpfTextViewMargin marginContainer)
        {
            var manager = LanguageElementManagerService.GetLanguageElementManager(wpfTextViewHost.TextView);
            if (manager == null)
                return null;

            return new DropdownBarMargin(wpfTextViewHost.TextView, manager, GlyphService);
        }
    }
}
