// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEP6.Database;

namespace SEP6.Database.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20210517100534_user fs")]
    partial class userfs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("MovieToplists", b =>
                {
                    b.Property<long>("MoviesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ToplistsesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MoviesId", "ToplistsesId");

                    b.HasIndex("ToplistsesId");

                    b.ToTable("MovieToplists");
                });

            modelBuilder.Entity("SEP6.Database.Director", b =>
                {
                    b.Property<long>("MovieId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("movie_id");

                    b.Property<long>("PersonId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("person_id");

                    b.HasIndex("MovieId");

                    b.HasIndex("PersonId");

                    b.ToTable("directors", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("SEP6.Database.Movie", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("title");

                    b.Property<byte[]>("Year")
                        .HasColumnType("NUMERIC")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.ToTable("movies", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("SEP6.Database.Toplists", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TopLists");
                });

            modelBuilder.Entity("SEP6.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SEP6.Person", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<byte[]>("Birth")
                        .HasColumnType("NUMERIC")
                        .HasColumnName("birth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("people", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("SEP6.Rating", b =>
                {
                    b.Property<long>("MovieId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("movie_id");

                    b.Property<double>("Rating1")
                        .HasColumnType("REAL")
                        .HasColumnName("rating");

                    b.Property<long>("Votes")
                        .HasColumnType("INTEGER")
                        .HasColumnName("votes");

                    b.HasIndex("MovieId");

                    b.ToTable("ratings", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("SEP6.Star", b =>
                {
                    b.Property<long>("MovieId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("movie_id");

                    b.Property<long>("PersonId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("person_id");

                    b.HasIndex("MovieId");

                    b.HasIndex("PersonId");

                    b.ToTable("stars", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.Property<int>("FollowersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FollowsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FollowersId", "FollowsId");

                    b.HasIndex("FollowsId");

                    b.ToTable("Followers");
                });

            modelBuilder.Entity("MovieToplists", b =>
                {
                    b.HasOne("SEP6.Database.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEP6.Database.Toplists", null)
                        .WithMany()
                        .HasForeignKey("ToplistsesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SEP6.Database.Director", b =>
                {
                    b.HasOne("SEP6.Database.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .IsRequired();

                    b.HasOne("SEP6.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("SEP6.Database.Toplists", b =>
                {
                    b.HasOne("SEP6.Database.User", null)
                        .WithMany("UserTopLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SEP6.Rating", b =>
                {
                    b.HasOne("SEP6.Database.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("SEP6.Star", b =>
                {
                    b.HasOne("SEP6.Database.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .IsRequired();

                    b.HasOne("SEP6.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.HasOne("SEP6.Database.User", null)
                        .WithMany()
                        .HasForeignKey("FollowersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEP6.Database.User", null)
                        .WithMany()
                        .HasForeignKey("FollowsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SEP6.Database.User", b =>
                {
                    b.Navigation("UserTopLists");
                });
#pragma warning restore 612, 618
        }
    }
}
