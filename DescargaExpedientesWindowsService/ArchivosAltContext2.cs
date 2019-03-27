// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace DescargaExpedientesWindowsService
{

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ArchivosAltContext2 : System.Data.Entity.DbContext, IArchivosAltContext2
    {

        static ArchivosAltContext2()
        {
            System.Data.Entity.Database.SetInitializer<ArchivosAltContext2>(null);
        }

        public ArchivosAltContext2()
            : base("Name=ARCHIVOS_ALT")
        {
        }

        public ArchivosAltContext2(string connectionString)
            : base(connectionString)
        {
        }

        public ArchivosAltContext2(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public ArchivosAltContext2(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public ArchivosAltContext2(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            return modelBuilder;
        }

        // Stored Procedures
        public System.Collections.Generic.List<SqPedimentosSirSaaiReturnModel> SqPedimentosSirSaai(string inicio, string fin, int? cliente, string grupo, int? opcion)
        {
            int procResult;
            return SqPedimentosSirSaai(inicio, fin, cliente, grupo, opcion, out procResult);
        }

        public System.Collections.Generic.List<SqPedimentosSirSaaiReturnModel> SqPedimentosSirSaai(string inicio, string fin, int? cliente, string grupo, int? opcion, out int procResult)
        {
            var inicioParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@inicio", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = inicio, Size = 10 };
            if (inicioParam.Value == null)
                inicioParam.Value = System.DBNull.Value;

            var finParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@fin", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = fin, Size = 10 };
            if (finParam.Value == null)
                finParam.Value = System.DBNull.Value;

            var clienteParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cliente", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = cliente.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!cliente.HasValue)
                clienteParam.Value = System.DBNull.Value;

            var grupoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@grupo", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = grupo, Size = 2 };
            if (grupoParam.Value == null)
                grupoParam.Value = System.DBNull.Value;

            var opcionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@opcion", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = opcion.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!opcion.HasValue)
                opcionParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SqPedimentosSirSaaiReturnModel>("EXEC @procResult = [dbo].[SQ_PedimentosSirSaai] @inicio, @fin, @cliente, @grupo, @opcion", inicioParam, finParam, clienteParam, grupoParam, opcionParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<SqPedimentosSirSaaiReturnModel>> SqPedimentosSirSaaiAsync(string inicio, string fin, int? cliente, string grupo, int? opcion)
        {
            var inicioParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@inicio", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = inicio, Size = 10 };
            if (inicioParam.Value == null)
                inicioParam.Value = System.DBNull.Value;

            var finParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@fin", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = fin, Size = 10 };
            if (finParam.Value == null)
                finParam.Value = System.DBNull.Value;

            var clienteParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cliente", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = cliente.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!cliente.HasValue)
                clienteParam.Value = System.DBNull.Value;

            var grupoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@grupo", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = grupo, Size = 2 };
            if (grupoParam.Value == null)
                grupoParam.Value = System.DBNull.Value;

            var opcionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@opcion", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = opcion.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!opcion.HasValue)
                opcionParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<SqPedimentosSirSaaiReturnModel>("EXEC [dbo].[SQ_PedimentosSirSaai] @inicio, @fin, @cliente, @grupo, @opcion", inicioParam, finParam, clienteParam, grupoParam, opcionParam).ToListAsync();

            return procResultData;
        }

    }
}
// </auto-generated>
