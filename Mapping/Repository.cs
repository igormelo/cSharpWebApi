using Desafio.Helpers;
using Desafio.Interface;
using Desafio.Models;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio.Mapping
{
    public class Repository
    {

        //Respositorio do Country
        public static void Create()
        {
            NhibernateHelper nh = new NhibernateHelper();
            using (var sf = nh.CreateSessionFactory())
            {
                sf.Close();
            }
        }
        public static void AddProject(Country country)
        {
            NhibernateHelper nh = new NhibernateHelper();
            using (var sf = nh.CreateSessionFactory())
            using (var session = sf.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {

                    session.SaveOrUpdate(country);
                    transaction.Commit();
                }
                catch(Exception e)
                {
                    throw new Exception("Error ao criar" + e.Message);
                }
            }
        }


        //Respositorio do Cadastro
        public static void Criar()
        {
            NhibernateHelper nh = new NhibernateHelper();
            using (var sf = nh.CreateCadastroFactory())
            {
                sf.Close();
            }
        }
        public static void Adicionar(Cadastro cadastro)
        {
            NhibernateHelper nh = new NhibernateHelper();
            using (var sf = nh.CreateCadastroFactory())
            using (var session = sf.OpenSession())
                using (var transaction = session.BeginTransaction())
            {
                try
                {
                    session.SaveOrUpdate(cadastro);
                    transaction.Commit();
                }
                catch(Exception e)
                {
                    throw new Exception("Erro ao criar: " + e.Message);
                }
                
            }

        }
        public static IList<Cadastro> Consultar()
        {
            NhibernateHelper nh = new NhibernateHelper();
            using (var sf = nh.CreateCadastroFactory())
            using (var session = sf.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                return (from e in session.Query<Cadastro>() select e).ToList();
            }
            
        }
        public static Cadastro RetornarPorId(int id)
        {
            NhibernateHelper nh = new NhibernateHelper();
            using (var sf = nh.CreateCadastroFactory())
            using (var session = sf.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
            
                return session.Get<Cadastro>(id);
            }

        }
        public static IEnumerable ObterTodos()
        {
            NhibernateHelper nh = new NhibernateHelper();
            using (var sf = nh.CreateCadastroFactory())
            using (var session = sf.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                return session.Query<Cadastro>().ToList();
            }
        }
        public static IEnumerable<Country> ObterPaises()
        {
            NhibernateHelper nh = new NhibernateHelper();
            using (var sf = nh.CreateCadastroFactory())
            using (var session = sf.OpenSession())
                using (var transaction = session.BeginTransaction())
            {
                return session.Query<Country>().ToList();
            }


        }
        public static Country RetornarPaisesPorId(int id)
        {
            NhibernateHelper nh = new NhibernateHelper();
            using (var sf = nh.CreateSessionFactory())
            using (var session = sf.OpenSession())
            using (var transaction = session.BeginTransaction())
            {

                return session.Get<Country>(id);
            }
        }

        }
        //public static Cadastro RetornarPorNome(string nome)
        //{
        //    NhibernateHelper nh = new NhibernateHelper();
        //    using (var sf = nh.CreateCadastroFactory())
        //    using (var session = sf.OpenSession())
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        return nome = session.QueryOver<Cadastro>().
        //            Where(p => p.Login = nome)
        //            .SingleOrDefault<string>();
        //    }

        //}
    
}