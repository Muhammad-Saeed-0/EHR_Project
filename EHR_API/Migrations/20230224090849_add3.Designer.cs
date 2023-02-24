﻿// <auto-generated />
using System;
using EHR_API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EHRAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230224090849_add3")]
    partial class add3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EHR_API.Entities.Models.Governorate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Governorates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7290),
                            Title = "القاهرة",
                            UpdateddAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7308)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7311),
                            Title = "الجيزة",
                            UpdateddAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7312)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7314),
                            Title = "مطروح",
                            UpdateddAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7314)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7316),
                            Title = "شمال سيناء",
                            UpdateddAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7316)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7318),
                            Title = "الشرقية",
                            UpdateddAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7319)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7320),
                            Title = "الدقهلية",
                            UpdateddAt = new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7321)
                        });
                });

            modelBuilder.Entity("EHR_API.Entities.Models.HealthFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDataId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubordinateTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GovernorateId");

                    b.HasIndex("RegistrationDataId");

                    b.ToTable("HealthFacilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Address1",
                            CreatedAt = new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8958),
                            Description = "Description1",
                            Email = "m@gmail.com",
                            GovernorateId = 1,
                            Phone1 = "01123456878",
                            Phone2 = "",
                            Phone3 = "",
                            RegistrationDataId = "12345678912345",
                            SubordinateTo = "المؤسسة العسكرية",
                            Title = "المستشفى العسكري بالشرقية",
                            Type = "مستشفى عسكري",
                            UpdateddAt = new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8977)
                        },
                        new
                        {
                            Id = 2,
                            Address = "Address2",
                            CreatedAt = new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8984),
                            Description = "Description2",
                            Email = "a@gmail.com",
                            GovernorateId = 1,
                            Phone1 = "01122456878",
                            Phone2 = "",
                            Phone3 = "",
                            RegistrationDataId = "12345678902341",
                            SubordinateTo = "وزارة الصحة",
                            Title = "المستشفى العام بالعريش",
                            Type = "مستشفى عام",
                            UpdateddAt = new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8985)
                        },
                        new
                        {
                            Id = 3,
                            Address = "Address3",
                            CreatedAt = new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8989),
                            Description = "Description3",
                            Email = "j@gmail.com",
                            GovernorateId = 1,
                            Phone1 = "01123416878",
                            Phone2 = "",
                            Phone3 = "",
                            RegistrationDataId = "12345678921345",
                            SubordinateTo = "مستشفيات الجامعة",
                            Title = "مستشفى الجامعة بالزقازيق",
                            Type = "مستشفى جامعي",
                            UpdateddAt = new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8990)
                        });
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.InsuranceData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasAnotherInsurance")
                        .HasColumnType("bit");

                    b.Property<bool>("HasGovernmentInsurance")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("InsuranceData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.MedicalData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DNAImageResultUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MedicalData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.MedicalTeam", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalSpecialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MedicalTeam");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.PersonalData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgeGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmergencyPhone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyPhone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<int>("NumOfChildren")
                        .HasColumnType("int");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GovernorateId");

                    b.ToTable("PersonalData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.RegistrationData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "12345678912345",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f78a47ac-7fdc-42c1-aa24-6ed83e1816e0",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "k@gmail.com",
                            EmailConfirmed = false,
                            FullName = "أحمد محمد كمال",
                            LockoutEnabled = false,
                            Nationality = "مصري",
                            NormalizedEmail = "K@GMAIL.COM",
                            NormalizedUserName = "@KAMAL123",
                            PasswordHash = "AQAAAAIAAYagAAAAED9/pAEdBfzU5tUdZv6pAImUhggZ2qWHJtxTUdO2FDeExyVPYCSc4RTZStdH2mviog==",
                            PhoneNumber = "01234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "64e76fcb-ac05-4af2-8e93-8deee1794888",
                            TwoFactorEnabled = false,
                            UpdateddAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "@Kamal123"
                        },
                        new
                        {
                            Id = "12345678902341",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "654d51ff-ddd6-46a3-9783-f464d807899c",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "A@gmail.com",
                            EmailConfirmed = false,
                            FullName = "أحمد محمد أحمد",
                            LockoutEnabled = false,
                            Nationality = "مصري",
                            NormalizedEmail = "A@GMAIL.COM",
                            NormalizedUserName = "@AHMED123",
                            PasswordHash = "AQAAAAIAAYagAAAAEB8G1lFXgRjXtI7kAJMYfzSy30ycJegvP3oi0t6tUgk2lsvIPfo8KUZAH3x/DNJF1w==",
                            PhoneNumber = "",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4686093c-c476-4a11-af35-b0bf8a5484bf",
                            TwoFactorEnabled = false,
                            UpdateddAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "@Ahmed123"
                        },
                        new
                        {
                            Id = "12345678921345",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "45eb8eb3-13c4-4d65-9345-d6fb733c46e0",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "M@gmail.com",
                            EmailConfirmed = false,
                            FullName = "أحمد محمد محمد",
                            LockoutEnabled = false,
                            Nationality = "مصري",
                            NormalizedEmail = "M@GMAIL.COM",
                            NormalizedUserName = "@MUHAMMAD123",
                            PasswordHash = "AQAAAAIAAYagAAAAECLU5sBhOqFbVV1cX/QALm3u3376RV/c+6kP05Uw9jJo4m4g5vSXlMzIQ5s2etpFZQ==",
                            PhoneNumber = "01234567899",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ba83c67d-dbb2-4eb3-aa7c-cbe8291903e1",
                            TwoFactorEnabled = false,
                            UpdateddAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "@Muhammad123"
                        },
                        new
                        {
                            Id = "92345678912345",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0c4d2713-17c1-48ba-ab8e-05d7fbda8d5e",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Al@gmail.com",
                            EmailConfirmed = false,
                            FullName = "أحمد محمد علي",
                            LockoutEnabled = false,
                            Nationality = "مصري",
                            NormalizedEmail = "AL@GMAIL.COM",
                            NormalizedUserName = "@ALI123",
                            PasswordHash = "AQAAAAIAAYagAAAAEMu08lhxfu1SgtcAev1VQ/hsICmjMfU/Va0NQd2iL5CxuDJjpAN5gftcvw90knDWBw==",
                            PhoneNumber = "01234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a326a3c0-9c8c-43ca-b690-94d3d3db0583",
                            TwoFactorEnabled = false,
                            UpdateddAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "@Ali123"
                        });
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.UserInsurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("InsuranceDataId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InsuranceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsuranceOrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsuranceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelationshipWithOrganization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceDataId");

                    b.ToTable("UserInsurance");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "SystemManager",
                            NormalizedName = "SYSTEMMANAGER"
                        },
                        new
                        {
                            Id = "2",
                            Name = "HealthFacilitiesAdministrator",
                            NormalizedName = "HEALTHFACILITIESADMINISTRATOR"
                        },
                        new
                        {
                            Id = "3",
                            Name = "HealthFacilityManager",
                            NormalizedName = "HEALTHFACILITYAMANAGER"
                        },
                        new
                        {
                            Id = "4",
                            Name = "Physician",
                            NormalizedName = "PHYSICIAN"
                        },
                        new
                        {
                            Id = "5",
                            Name = "Nurse",
                            NormalizedName = "NURSE"
                        },
                        new
                        {
                            Id = "6",
                            Name = "Pharmacist",
                            NormalizedName = "PHARMACIST"
                        },
                        new
                        {
                            Id = "7",
                            Name = "Patient",
                            NormalizedName = "PATIENT"
                        },
                        new
                        {
                            Id = "8",
                            Name = "Technician",
                            NormalizedName = "TECHNICIAN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "12345678912345",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "12345678902341",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "12345678921345",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "92345678912345",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EHR_API.Entities.Models.HealthFacility", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.Governorate", "Governorate")
                        .WithMany("HealthFacilitys")
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", "RegistrationData")
                        .WithMany("HealthFacilities")
                        .HasForeignKey("RegistrationDataId");

                    b.Navigation("Governorate");

                    b.Navigation("RegistrationData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.InsuranceData", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", "RegistrationData")
                        .WithOne("InsuranceData")
                        .HasForeignKey("EHR_API.Entities.Models.UsersData.InsuranceData", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegistrationData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.MedicalData", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", "RegistrationData")
                        .WithOne("MedicalData")
                        .HasForeignKey("EHR_API.Entities.Models.UsersData.MedicalData", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegistrationData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.MedicalTeam", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", "RegistrationData")
                        .WithOne("MedicalTeam")
                        .HasForeignKey("EHR_API.Entities.Models.UsersData.MedicalTeam", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegistrationData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.PersonalData", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.Governorate", "Governorate")
                        .WithMany("PersonalData")
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", "RegistrationData")
                        .WithOne("PersonalData")
                        .HasForeignKey("EHR_API.Entities.Models.UsersData.PersonalData", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governorate");

                    b.Navigation("RegistrationData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.UserInsurance", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.InsuranceData", "InsuranceData")
                        .WithMany("UserInsurances")
                        .HasForeignKey("InsuranceDataId");

                    b.Navigation("InsuranceData");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EHR_API.Entities.Models.Governorate", b =>
                {
                    b.Navigation("HealthFacilitys");

                    b.Navigation("PersonalData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.InsuranceData", b =>
                {
                    b.Navigation("UserInsurances");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.RegistrationData", b =>
                {
                    b.Navigation("HealthFacilities");

                    b.Navigation("InsuranceData");

                    b.Navigation("MedicalData");

                    b.Navigation("MedicalTeam");

                    b.Navigation("PersonalData");
                });
#pragma warning restore 612, 618
        }
    }
}
