using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FerieDyrCore.Models;

namespace FerieDyrCore.Migrations
{
    [DbContext(typeof(FerieDyrCoreContext))]
    [Migration("20170308210317_FerieDyrFirstMigration")]
    partial class FerieDyrFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FerieDyrCore.Models.HelloCoreModel", b =>
                {
                    b.Property<int>("HelloCoreModelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<int>("Number");

                    b.HasKey("HelloCoreModelId");

                    b.ToTable("HelloCoreModels");
                });
        }
    }
}
