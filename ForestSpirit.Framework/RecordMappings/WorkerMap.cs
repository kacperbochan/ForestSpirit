using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Products.Records;

/// <summary>
/// Mapowanie rekordu pracownika.
/// </summary>
public class WorkerMap : ClassMap<WorkerRecord>
{
    public WorkerMap()
    {
        this.Table("Worker");
        this.Id(x => x.Id);
        this.Map(x => x.Name);
        this.Map(x => x.Wage);
        this.Map(x => x.Type);
        this.Map(x => x.Status);
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
        this.HasMany(x => x.Requests);
    }
}
