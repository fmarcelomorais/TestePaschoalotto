﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestePaschoalotto.Infraestrutura.Context;

#nullable disable

namespace TestePaschoalotto.Infraestrutura.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240620044416_AlteraTabelaId")]
    partial class AlteraTabelaId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Coordinates", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cordinates");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Dob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Dobs");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Identity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Identity");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("CoordinatesId")
                        .HasColumnType("uuid");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Postcode")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("StreetId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TimezoneId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CoordinatesId");

                    b.HasIndex("StreetId");

                    b.HasIndex("TimezoneId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Login", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Md5")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sha1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sha256")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Name", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("First")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Last")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Names");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Picture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Large")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Medium")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Registered", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Registereds");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Street", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Timezone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Offset")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Timezones");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Cell")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("CoordinateId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DobId")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("IdentityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LoginId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("NameId")
                        .HasColumnType("uuid");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PictureId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RegisteredId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DobId");

                    b.HasIndex("IdentityId");

                    b.HasIndex("LocationId");

                    b.HasIndex("LoginId");

                    b.HasIndex("NameId");

                    b.HasIndex("PictureId");

                    b.HasIndex("RegisteredId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Location", b =>
                {
                    b.HasOne("TestePaschoalotto.Domain.Model.Coordinates", "Coordinates")
                        .WithMany()
                        .HasForeignKey("CoordinatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestePaschoalotto.Domain.Model.Street", "Street")
                        .WithMany()
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestePaschoalotto.Domain.Model.Timezone", "Timezone")
                        .WithMany()
                        .HasForeignKey("TimezoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coordinates");

                    b.Navigation("Street");

                    b.Navigation("Timezone");
                });

            modelBuilder.Entity("TestePaschoalotto.Domain.Model.Usuario", b =>
                {
                    b.HasOne("TestePaschoalotto.Domain.Model.Dob", "Dob")
                        .WithMany()
                        .HasForeignKey("DobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestePaschoalotto.Domain.Model.Identity", "Identity")
                        .WithMany()
                        .HasForeignKey("IdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestePaschoalotto.Domain.Model.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestePaschoalotto.Domain.Model.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestePaschoalotto.Domain.Model.Name", "Name")
                        .WithMany()
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestePaschoalotto.Domain.Model.Picture", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestePaschoalotto.Domain.Model.Registered", "Registered")
                        .WithMany()
                        .HasForeignKey("RegisteredId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dob");

                    b.Navigation("Identity");

                    b.Navigation("Location");

                    b.Navigation("Login");

                    b.Navigation("Name");

                    b.Navigation("Picture");

                    b.Navigation("Registered");
                });
#pragma warning restore 612, 618
        }
    }
}
