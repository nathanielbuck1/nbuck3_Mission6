// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(movieFormContext))]
    partial class movieFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "VHS"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("Mission6.Models.FormResponse", b =>
                {
                    b.Property<int>("AppID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            AppID = 1,
                            CategoryID = 1,
                            Director = "Nathaniel",
                            Edited = true,
                            LentTo = "Yo MAMA",
                            Notes = "Bombbbb",
                            Rating = "G",
                            Title = "The great one",
                            Year = 1999
                        },
                        new
                        {
                            AppID = 2,
                            CategoryID = 1,
                            Director = "Buck",
                            Edited = true,
                            LentTo = "Yo MAMA",
                            Notes = "Bombbbb",
                            Rating = "PG",
                            Title = "The last one",
                            Year = 1989
                        },
                        new
                        {
                            AppID = 3,
                            CategoryID = 2,
                            Director = "Tadao",
                            Edited = true,
                            LentTo = "Yo MAMA",
                            Notes = "Bombbbb.COM",
                            Rating = "PG",
                            Title = "The Mid one",
                            Year = 2020
                        });
                });

            modelBuilder.Entity("Mission6.Models.FormResponse", b =>
                {
                    b.HasOne("Mission6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
