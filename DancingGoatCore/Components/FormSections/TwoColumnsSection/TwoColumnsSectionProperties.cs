using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;

namespace DancingGoat.Components.FormSections.TwoColumnsSection
{
    public class TwoColumnsSectionProperties : IFormSectionProperties
    {
        [EditingComponent(RichTextComponent.IDENTIFIER, Label = "Title")]
        public string Title { get; set; }
    }
}
