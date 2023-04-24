using DancingGoat.Components.FormSections.TitledSection;
using DancingGoat.Components.FormSections.TwoColumnsSection;
using DancingGoat.Components.FormSections.CustomSection;
using Kentico.Forms.Web.Mvc;
[assembly: RegisterFormSection("DancingGoat.TitledSection", "Section with title", "~/Components/FormSections/TitledSection/_TitledSection.cshtml", Description = "Single-column section with one zone and an editable title", IconClass = "icon-rectangle-a", PropertiesType = typeof(TitledSectionProperties))]
[assembly: RegisterFormSection("DancingGoat.TwoColumnsSection", "Two column section", "~/Components/FormSections/TwoColumnsSection/_TwoColumnsSection.cshtml", Description = "Two-column section with two zones and an editable title", IconClass = "icon-l-cols-2", PropertiesType = typeof(TwoColumnsSectionProperties))]
[assembly: RegisterFormSection("DancingGoat.CustomSection", "Custom section", "~/Components/FormSections/CustomSection/_CustomSection.cshtml", Description = "Custom section applying css", IconClass = "icon-square", PropertiesType = typeof(CustomSectionProperties))]
[assembly: RegisterFormSection("DancingGoat.CustomRadioSection", "Custom radio section", "~/Components/FormSections/CustomRadioSection/_CustomRadioSection.cshtml", Description = "Custom section applying css for radio vertical option list", IconClass = "icon-rb-check")]