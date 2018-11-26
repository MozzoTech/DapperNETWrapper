using System.Linq;
using Dapper;

namespace DapperWrapper
{
    public static class EXTENSION_METHODS
    {
        public static bool hasRows(this SqlMapper.GridReader grid_reader)
        {
            return !grid_reader.IsConsumed;
        }

        public static int Length(this DynamicParameters dp)
        {
            return dp.ParameterNames.Count();
        }
    }
}
