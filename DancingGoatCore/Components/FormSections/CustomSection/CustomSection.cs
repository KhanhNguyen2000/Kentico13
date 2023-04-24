using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;

namespace DancingGoat.Components.FormSections.CustomSection
{
    public class CustomSectionProperties : IFormSectionProperties
    {
        [EditingComponent(RichTextComponent.IDENTIFIER, Label = "Title")]
        public string Title { get; set; }
    }
}
