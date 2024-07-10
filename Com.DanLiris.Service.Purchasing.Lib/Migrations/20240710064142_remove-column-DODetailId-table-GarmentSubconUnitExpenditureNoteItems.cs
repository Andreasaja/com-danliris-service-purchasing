using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Com.DanLiris.Service.Purchasing.Lib.Migrations
{
    public partial class removecolumnDODetailIdtableGarmentSubconUnitExpenditureNoteItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "DODetailId",
               table: "GarmentSubconUnitExpenditureNoteItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
