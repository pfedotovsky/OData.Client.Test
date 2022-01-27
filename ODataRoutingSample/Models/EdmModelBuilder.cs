using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace ODataRoutingSample.Models
{
    public static class EdmModelBuilder
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();

            // unbound
            builder.Action("ResetData");

            // using attribute routing
            var unboundFunction = builder.Function("CalculateSalary").Returns<string>();
            unboundFunction.Parameter<int>("minSalary");
            unboundFunction.Parameter<int>("maxSalary").Optional();
            unboundFunction.Parameter<string>("wholeName").HasDefaultValue("abc");
            return builder.GetEdmModel();
        }
    }
}
