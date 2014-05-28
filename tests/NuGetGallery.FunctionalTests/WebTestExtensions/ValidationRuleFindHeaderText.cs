﻿using Microsoft.VisualStudio.TestTools.WebTesting;

namespace NuGetGallery.FunctionTests.Helpers
{
    /// <summary>
    ///     Validation rule for matching text in response headers.
    /// </summary>
    class ValidationRuleFindHeaderText : ValidationRule
    {
        public ValidationRuleFindHeaderText()
        {
        }

        public ValidationRuleFindHeaderText(string findText)
        {
            FindText = findText;
        }

        public string FindText { get; set; }

        public override void Validate(object sender, ValidationEventArgs e)
        {
            if (e.Response.Headers.ToString().Contains(FindText)) 
            { 
                e.IsValid = true; 
            } else {
                e.IsValid = false; 
            }
        }
    }
}
