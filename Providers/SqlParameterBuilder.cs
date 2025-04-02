using Microsoft.Data.SqlClient;
using System.Data;

namespace YStore.Providers
{
    public class SqlParameterBuilder
    {
        private readonly List<SqlParameter> _parameters = new();

        public SqlParameterBuilder Add(string name, SqlDbType type, object? value, int? size = null)
        {
            var parameter = new SqlParameter(name, type)
            {
                Value = value ?? DBNull.Value
            };

            if (size.HasValue)
            {
                parameter.Size = size.Value;
            }

            _parameters.Add(parameter);
            return this;
        }

        public SqlParameter[] Build() => _parameters.ToArray();
    }

}
