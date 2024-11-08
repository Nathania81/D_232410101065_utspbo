using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_232410101065_utspbo.App.Context
{
    internal class Buku
    {
        public static DataTable All()
        {
            string query = @"
        SELECT 
            m.id,
            m.judul,
            m.pengarang,
            m.tahun_terbit
            
            FROM
                buku b";

            DataTable dataBuku = queryExecutor(query);
            return dataBuku;
        }
    }
    public static DataTable getBukuById(int id)
    {
        string query = @"
                SELECT 
                    m.id,
                    m.judul,
                    m.pengarang,
                    m.tahun_terbit
                FROM 
                    buku b";

        NpgsqlParameter[] parameters =
        {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

        DataTable dataBuku = queryExecutor(query, parameters);
        return dataBuku;
    }
    public bool Read()
    {
        bool isSuccess = false;
        string 
    }

}
