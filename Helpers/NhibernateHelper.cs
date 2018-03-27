
using Desafio.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio.Helpers
{
    internal class NhibernateHelper: IDisposable
    {
        public static ISessionFactory sessionFactory;
        protected ISession session { get; set; }
        public Configuration configuration;


        public ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile("Banco.db").ShowSql().ConnectionString("Data Source=C:/Users/igor.leite/Desktop/Database/Banco.db;new=True;Version=3"))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Country>())
                .ExposeConfiguration(CriarSchema)   
                .BuildSessionFactory();
        }
        public ISessionFactory CreateCadastroFactory()
        {
            return Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile("Banco.db").ShowSql().ConnectionString("Data Source=C:/Users/igor.leite/Desktop/Database/Banco.db;new=True;Version=3"))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Cadastro>())
                .ExposeConfiguration(CriarSchema)
                .BuildSessionFactory();
        }

        protected void CriarSchema(Configuration config)
        {
            new SchemaUpdate(config).Execute(false, true);//(true, true, false, session.Connection, null);
        }
        public void Dispose()
        {
            if(sessionFactory != null)
            {
                sessionFactory.Dispose();
            }
            sessionFactory = null;
            configuration = null;
        }
    }
}