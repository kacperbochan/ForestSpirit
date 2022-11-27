using FluentNHibernate.Mapping;
using ForestSpirit.Framework.Products.Records;

/// <summary>
/// Mapowanie rekordu zlecenia.
/// </summary>
public class RequestMap : ClassMap<RequestRecord>
{
    public RequestMap()
    {
        this.Table("Worker");
        this.Id(x => x.Id);
        this.Map(x => x.Title);
        this.Map(x => x.Content);
        this.Map(x => x.ChangedBy).Column("Changed_By");
        this.Map(x => x.ChangedDate).Column("Changed_At");
        this.Map(x => x.CreatedBy).Column("Created_By");
        this.Map(x => x.CreatedDate).Column("Created_At");
        this.References(x => x.Sender)
            .Column("SenderId")
            .Cascade.All();
        this.References(x => x.Receiver)
            .Column("ReceiverId")
            .Cascade.All();
    }
}
