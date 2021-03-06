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


namespace InternetReports.Models
{

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public class ARCHIVOS_ALT : System.Data.Entity.DbContext, IARCHIVOS_ALT
    {
        public System.Data.Entity.DbSet<CatCliente> CatClientes { get; set; } // cat_clientes
        public System.Data.Entity.DbSet<PedimentosSaaiSirView> PedimentosSaaiSirViews { get; set; } // SQ_VT_PedimentosSaaiSir

        static ARCHIVOS_ALT()
        {
            System.Data.Entity.Database.SetInitializer<ARCHIVOS_ALT>(null);
        }

        public ARCHIVOS_ALT()
            : base("Name=ARCHIVOS_ALT")
        {
        }

        public ARCHIVOS_ALT(string connectionString)
            : base(connectionString)
        {
        }

        public ARCHIVOS_ALT(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public ARCHIVOS_ALT(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public ARCHIVOS_ALT(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
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

            modelBuilder.Configurations.Add(new CatClienteConfiguration());
            modelBuilder.Configurations.Add(new PedimentosSaaiSirViewConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CatClienteConfiguration(schema));
            modelBuilder.Configurations.Add(new PedimentosSaaiSirViewConfiguration(schema));
            return modelBuilder;
        }

        // Stored Procedures
        public System.Collections.Generic.List<UspRecuperarComplementosDePagoPorClienteReturnModel> UspRecuperarComplementosDePagoPorCliente(int? idCliente, System.DateTime? fechaInicio, System.DateTime? fechaFin, int? idObjeto, string serie, string folio)
        {
            int procResult;
            return UspRecuperarComplementosDePagoPorCliente(idCliente, fechaInicio, fechaFin, idObjeto, serie, folio, out procResult);
        }

        public System.Collections.Generic.List<UspRecuperarComplementosDePagoPorClienteReturnModel> UspRecuperarComplementosDePagoPorCliente(int? idCliente, System.DateTime? fechaInicio, System.DateTime? fechaFin, int? idObjeto, string serie, string folio, out int procResult)
        {
            var idClienteParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@IdCliente", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = idCliente.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!idCliente.HasValue)
                idClienteParam.Value = System.DBNull.Value;

            var fechaInicioParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@FechaInicio", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = fechaInicio.GetValueOrDefault() };
            if (!fechaInicio.HasValue)
                fechaInicioParam.Value = System.DBNull.Value;

            var fechaFinParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@FechaFin", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = fechaFin.GetValueOrDefault() };
            if (!fechaFin.HasValue)
                fechaFinParam.Value = System.DBNull.Value;

            var idObjetoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@IdObjeto", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = idObjeto.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!idObjeto.HasValue)
                idObjetoParam.Value = System.DBNull.Value;

            var serieParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Serie", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = serie, Size = 30 };
            if (serieParam.Value == null)
                serieParam.Value = System.DBNull.Value;

            var folioParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Folio", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = folio, Size = 30 };
            if (folioParam.Value == null)
                folioParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UspRecuperarComplementosDePagoPorClienteReturnModel>("EXEC @procResult = [dbo].[USP_RecuperarComplementosDePagoPorCliente] @IdCliente, @FechaInicio, @FechaFin, @IdObjeto, @Serie, @Folio", idClienteParam, fechaInicioParam, fechaFinParam, idObjetoParam, serieParam, folioParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<UspRecuperarComplementosDePagoPorClienteReturnModel>> UspRecuperarComplementosDePagoPorClienteAsync(int? idCliente, System.DateTime? fechaInicio, System.DateTime? fechaFin, int? idObjeto, string serie, string folio)
        {
            var idClienteParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@IdCliente", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = idCliente.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!idCliente.HasValue)
                idClienteParam.Value = System.DBNull.Value;

            var fechaInicioParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@FechaInicio", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = fechaInicio.GetValueOrDefault() };
            if (!fechaInicio.HasValue)
                fechaInicioParam.Value = System.DBNull.Value;

            var fechaFinParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@FechaFin", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = fechaFin.GetValueOrDefault() };
            if (!fechaFin.HasValue)
                fechaFinParam.Value = System.DBNull.Value;

            var idObjetoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@IdObjeto", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = idObjeto.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!idObjeto.HasValue)
                idObjetoParam.Value = System.DBNull.Value;

            var serieParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Serie", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = serie, Size = 30 };
            if (serieParam.Value == null)
                serieParam.Value = System.DBNull.Value;

            var folioParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Folio", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = folio, Size = 30 };
            if (folioParam.Value == null)
                folioParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<UspRecuperarComplementosDePagoPorClienteReturnModel>("EXEC [dbo].[USP_RecuperarComplementosDePagoPorCliente] @IdCliente, @FechaInicio, @FechaFin, @IdObjeto, @Serie, @Folio", idClienteParam, fechaInicioParam, fechaFinParam, idObjetoParam, serieParam, folioParam).ToListAsync();

            return procResultData;
        }

    }
}
// </auto-generated>
