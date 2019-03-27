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
    public class FakeARCHIVOS_ALT : IARCHIVOS_ALT
    {
        public System.Data.Entity.DbSet<CatCliente> CatClientes { get; set; }
        public System.Data.Entity.DbSet<PedimentosSaaiSirView> PedimentosSaaiSirViews { get; set; }

        public FakeARCHIVOS_ALT()
        {
            CatClientes = new FakeDbSet<CatCliente>("IdCli");
            PedimentosSaaiSirViews = new FakeDbSet<PedimentosSaaiSirView>("Sistema");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        // Stored Procedures
        public System.Collections.Generic.List<UspRecuperarComplementosDePagoPorClienteReturnModel> UspRecuperarComplementosDePagoPorCliente(int? idCliente, System.DateTime? fechaInicio, System.DateTime? fechaFin, int? idObjeto, string serie, string folio)
        {
            int procResult;
            return UspRecuperarComplementosDePagoPorCliente(idCliente, fechaInicio, fechaFin, idObjeto, serie, folio, out procResult);
        }

        public System.Collections.Generic.List<UspRecuperarComplementosDePagoPorClienteReturnModel> UspRecuperarComplementosDePagoPorCliente(int? idCliente, System.DateTime? fechaInicio, System.DateTime? fechaFin, int? idObjeto, string serie, string folio, out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<UspRecuperarComplementosDePagoPorClienteReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<UspRecuperarComplementosDePagoPorClienteReturnModel>> UspRecuperarComplementosDePagoPorClienteAsync(int? idCliente, System.DateTime? fechaInicio, System.DateTime? fechaFin, int? idObjeto, string serie, string folio)
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(UspRecuperarComplementosDePagoPorCliente(idCliente, fechaInicio, fechaFin, idObjeto, serie, folio, out procResult));
        }

    }
}
// </auto-generated>