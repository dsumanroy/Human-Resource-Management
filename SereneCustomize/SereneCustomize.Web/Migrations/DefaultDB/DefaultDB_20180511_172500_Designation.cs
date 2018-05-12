using FluentMigrator;

namespace SereneCustomize.Migrations.DefaultDB
{
    [Migration(20180511172500)]
    public class DefaultDB_20180511_172500_Designation : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId64("Designation", "Id", s => s
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Remarks").AsString().Nullable());

            Alter.Table("Users").AddColumn("DesignationId").AsInt64().Nullable().ForeignKey("Designation", "Id")
                .AddColumn("BirthDate").AsDate().Nullable()
                .AddColumn("Gender").AsString().Nullable();

        }


    }
}