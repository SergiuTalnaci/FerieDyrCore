using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FerieDyrCore.Models;

namespace FerieDyrCore.Migrations
{
    [DbContext(typeof(FerieDyrCoreContext))]
    partial class FerieDyrCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
