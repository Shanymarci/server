/*using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using sql.Data;

public class SqlConnectionMiddleware
{
    private readonly RequestDelegate next;
    private readonly SqlConnectionFactory connectionFactory;

    public SqlConnectionMiddleware(RequestDelegate next, SqlConnectionFactory connectionFactory)
    {
        this.next = next;
        this.connectionFactory = connectionFactory;
    }

    public async Task Invoke(HttpContext context)
    {
        using (SqlConnection connection = connectionFactory.GetOpenConnection())
        {
            // Attach the connection to the HttpContext for access in controllers
            context.Items["SqlConnection"] = connection;

            try
            {
                await next(context);
            }
            finally
            {
                // Dispose the connection after the request is processed
                connection.Dispose();
            }
        }
    }
}
*/