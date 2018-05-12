using FluentMigrator;

namespace SereneCustomize.Migrations.DefaultDB
{
    [Migration(20180511114500)]
    public class DefaultDB_20180511_114500_DailyAttendance : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId64("DailyAttendance", "Id", s => s
                .WithColumn("UserId").AsInt32().NotNullable().ForeignKey("Users", "UserId")
                .WithColumn("AttendanceDate").AsDateTime().NotNullable());
                
        }
    }
}