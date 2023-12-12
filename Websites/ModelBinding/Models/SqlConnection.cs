namespace ModelBinding.Models
{
    internal class SqlConnection
    {
        internal string ConnectionString;

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        public static implicit operator Microsoft.Data.SqlClient.SqlConnection(SqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}