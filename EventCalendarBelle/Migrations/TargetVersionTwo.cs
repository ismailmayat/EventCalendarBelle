﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Persistence.Migrations;

namespace EventCalendarBelle.Migrations
{
    [Migration("2.0.1", 0, "UpdateEventCalendarTables")]
    public class EventMigration : MigrationBase
    {
        public override void Down()
        {
            Delete.Column("categories").FromTable("ec_events");
        }

        public override void Up()
        {
            Alter.Table("ec_events").AddColumn("categories").AsString().Nullable();
        }
    }

    [Migration("2.0.1", 1, "UpdateEventCalendarTables")]
    public class RecEventMigration : MigrationBase
    {
        public override void Down()
        {
            Delete.Column("categories").FromTable("ec_recevents");
        }

        public override void Up()
        {
            Alter.Table("ec_recevents").AddColumn("categories").AsString().Nullable();
        }
    }
}
