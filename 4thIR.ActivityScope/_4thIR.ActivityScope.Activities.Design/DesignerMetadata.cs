using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using _4thIR.ActivityScope.Activities.Design.Designers;
using _4thIR.ActivityScope.Activities.Design.Properties;

namespace _4thIR.ActivityScope.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");

            builder.AddCustomAttributes(typeof(ActivityScope), categoryAttribute);
            builder.AddCustomAttributes(typeof(ActivityScope), new DesignerAttribute(typeof(ActivityScopeDesigner)));
            builder.AddCustomAttributes(typeof(ActivityScope), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
