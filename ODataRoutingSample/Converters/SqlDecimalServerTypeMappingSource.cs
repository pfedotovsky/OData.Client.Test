using Microsoft.EntityFrameworkCore.Storage;

namespace ODataRoutingSample.Converters
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "EF1001:Internal EF Core API usage.", Justification = "<replace decimal(18,2)>")]
    internal class SqlDecimalServerTypeMappingSource : Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal.SqlServerTypeMappingSource
    {
        private static readonly RelationalTypeMappingInfo defaultDecimalMappingInfo = new RelationalTypeMappingInfo("decimal(18, 8)", "decimal", null, null, 18, 8);

        public SqlDecimalServerTypeMappingSource(TypeMappingSourceDependencies dependencies, RelationalTypeMappingSourceDependencies relationalDependencies)
                : base(dependencies, relationalDependencies)
        {
        }

        protected override RelationalTypeMapping FindMapping(in RelationalTypeMappingInfo mappingInfo)
        {
            if (mappingInfo.ClrType == typeof(decimal) && !mappingInfo.Scale.HasValue)
            {
                return base.FindMapping(defaultDecimalMappingInfo);
            }

            return base.FindMapping(mappingInfo);
        }
    }
}
