using DancingGoat;
using DancingGoat.Sections;
using DancingGoat.PageTemplates;
using DancingGoat.Widgets;

using Kentico.PageBuilder.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;

// Widgets
[assembly: RegisterWidget(ComponentIdentifiers.TESTIMONIAL_WIDGET, "Testimonial", typeof(TestimonialWidgetProperties), "~/Components/Widgets/TestimonialWidget/_DancingGoat_LandingPage_TestimonialWidget.cshtml", Description = "Displays a quotation with its author.", IconClass = "icon-right-double-quotation-mark")]
[assembly: RegisterWidget(ComponentIdentifiers.CTA_BUTTON_WIDGET, "CTA button", typeof(CTAButtonWidgetProperties), "~/Components/Widgets/CTAButton/_DancingGoat_General_CTAButtonWidget.cshtml", Description = "Call to action button with configurable target page.", IconClass = "icon-rectangle-a")]
// my widgets
[assembly: RegisterWidget(ComponentIdentifiers.MY_CTA_BUTTON_WIDGET, "My CTA button", typeof(MyCTAButtonWidgetProperties), "~/Components/Widgets/MyCTAButton/_MyCTAButtonWidget.cshtml", Description = "Call to action button with configurable target page.", IconClass = "icon-rectangle-a")]

// Sections
[assembly: RegisterSection(ComponentIdentifiers.SINGLE_COLUMN_SECTION, "1 column", typeof(ThemeSectionProperties), "~/Components/Sections/_DancingGoat_SingleColumnSection.cshtml", Description = "Single-column section with one full-width zone.", IconClass = "icon-square")]
[assembly: RegisterSection(ComponentIdentifiers.TWO_COLUMN_SECTION, "2 columns - 50/50", typeof(ThemeSectionProperties), "~/Components/Sections/_DancingGoat_TwoColumnSection.cshtml", Description = "Two-column section with zones layout 50% + 50%.", IconClass = "icon-l-cols-2")]
[assembly: RegisterSection(ComponentIdentifiers.THREE_COLUMN_SECTION, "3 columns - 33/33/33", typeof(ThreeColumnSectionProperties), "~/Components/Sections/ThreeColumnSection/_DancingGoat_ThreeColumnSection.cshtml", Description = "Three-column section with zones layout 33% + 33% + 33%.", IconClass = "icon-l-cols-3")]
[assembly: RegisterSection(ComponentIdentifiers.SECTION_75_25, "2 columns - 75/25", typeof(ThemeSectionProperties), "~/Components/Sections/_DancingGoat_Section_75_25.cshtml", Description = "Two-column section with zones layout 75% + 25%.", IconClass = "icon-l-cols-70-30")]
[assembly: RegisterSection(ComponentIdentifiers.SECTION_25_75, "2 columns - 25/75", typeof(ThemeSectionProperties), "~/Components/Sections/_DancingGoat_Section_25_75.cshtml", Description = "Two-column section with zones layout 25% + 75%.", IconClass = "icon-l-cols-30-70")]

[assembly: RegisterSection(ComponentIdentifiers.SECTION_30_30_30_30, "4 columns - 3/3/3/3", typeof(ThemeSectionProperties), "~/Components/Sections/Section_9.cshtml", Description = "4-column section with zones layout 25% + 25% + 25% + 25%.", IconClass = "icon-l-cols-30-30-30-30")]

// Page templates
[assembly: RegisterPageTemplate(ComponentIdentifiers.LANDING_PAGE_SINGLE_COLUMN_TEMPLATE, "Single column landing page", typeof(LandingPageSingleColumnProperties), "~/PageTemplates/LandingPage/_DancingGoat_LandingPageSingleColumn.cshtml", Description = "A default single column page template with two sections differentiated by a background color.")]