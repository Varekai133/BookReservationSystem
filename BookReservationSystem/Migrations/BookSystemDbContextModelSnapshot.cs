﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookReservationSystem.Migrations
{
    [DbContext(typeof(BookSystemDbContext))]
    partial class BookSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Models.Book", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Models.ReservationHistoryRecord", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint?>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("ReservationHistoryRecords");
                });

            modelBuilder.Entity("Models.ReservedBook", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint?>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("ReservedBooks");
                });

            modelBuilder.Entity("Models.ReservationHistoryRecord", b =>
                {
                    b.HasOne("Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Models.ReservedBook", b =>
                {
                    b.HasOne("Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.Navigation("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
