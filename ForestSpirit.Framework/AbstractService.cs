using ForestSpirit.Framework.Data;
using ForestSpirit.Framework.Products.Records;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestSpirit.Framework;
public abstract class AbstractService<TRecord>
    where TRecord : IRecord
{
    public AbstractService(ISessionFactory db)
    {
        this.Db = db;
    }

    /// <summary>
    /// Połączenie z bazą danych.
    /// </summary>
    protected ISessionFactory Db { get; private set; }

    public virtual int GetNewId()
    {
        return this.GetAll().Max(x => x.Id) + 1;
    }

    public virtual List<TRecord> GetAll()
    {
        // pobranie danych
        using (var session = this.Db.OpenSession())
        {
            return session.Query<TRecord>().ToList();
        }
    }

    public virtual TRecord Get(int id)
    {
        if (id <= 0)
        {
            return default;
        }

        // pobranie danych
        using (var session = this.Db.OpenSession())
        {
            return session.Get<TRecord>(id);
        }
    }
}
