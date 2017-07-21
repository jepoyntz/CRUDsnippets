using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SnippetApp.Models;

namespace CRUDsnippets.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20170721181907_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("CrudSnippets.Models.Snippet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Decsription");

                    b.Property<string>("Language");

                    b.Property<string>("Snipp");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Snippets");
                });
        }
    }
}
