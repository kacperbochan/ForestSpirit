using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Products.Records;

public class WorkerMap : ClassMap<WorkerRecord>
{
    public WorkerMap()
    {
        this.Id(x => x.ID);
        this.Map(x => x.Name);
        this.Map(x => x.Wage);
        this.Map(x => x.Type);
        this.Map(x => x.Status);
    }
}
