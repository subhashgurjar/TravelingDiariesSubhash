﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelingDiaries.Models;

#nullable disable

namespace TravelingDiaries.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220823154532_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TravelingDiaries.Models.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightId"), 1L, 1);

                    b.Property<string>("FlightName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlightId");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            FlightId = 1,
                            FlightName = "KingFisher",
                            From = "Jaipur",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Mumbai"
                        },
                        new
                        {
                            FlightId = 2,
                            FlightName = "KingFisher",
                            From = "Mumbai",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Jaipur"
                        },
                        new
                        {
                            FlightId = 3,
                            FlightName = "SpiceJet",
                            From = "Jaipur",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Mumbai"
                        },
                        new
                        {
                            FlightId = 4,
                            FlightName = "SpiceJet",
                            From = "Mumbai",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Jaipur"
                        },
                        new
                        {
                            FlightId = 5,
                            FlightName = "KingFisher",
                            From = "Jaipur",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Delhi"
                        },
                        new
                        {
                            FlightId = 6,
                            FlightName = "KingFisher",
                            From = "Delhi",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Jaipur"
                        },
                        new
                        {
                            FlightId = 7,
                            FlightName = "SpiceJet",
                            From = "Jaipur",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Delhi"
                        },
                        new
                        {
                            FlightId = 8,
                            FlightName = "SpiceJet",
                            From = "Delhi",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Jaipur"
                        },
                        new
                        {
                            FlightId = 9,
                            FlightName = "KingFisher",
                            From = "Jaipur",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Chennai"
                        },
                        new
                        {
                            FlightId = 10,
                            FlightName = "KingFisher",
                            From = "Chennai",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Jaipur"
                        },
                        new
                        {
                            FlightId = 11,
                            FlightName = "SpiceJet",
                            From = "Jaipur",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Chennai"
                        },
                        new
                        {
                            FlightId = 12,
                            FlightName = "SpiceJet",
                            From = "Chennai",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Jaipur"
                        },
                        new
                        {
                            FlightId = 13,
                            FlightName = "KingFisher",
                            From = "Jaipur",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Jammu & Kashmir"
                        },
                        new
                        {
                            FlightId = 14,
                            FlightName = "KingFisher",
                            From = "Jammu & Kashmir",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Jaipur"
                        },
                        new
                        {
                            FlightId = 15,
                            FlightName = "SpiceJet",
                            From = "Jaipur",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Jammu & Kashmir"
                        },
                        new
                        {
                            FlightId = 16,
                            FlightName = "SpiceJet",
                            From = "Jammu & Kashmir",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Jaipur"
                        },
                        new
                        {
                            FlightId = 17,
                            FlightName = "KingFisher",
                            From = "Delhi",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Mumbai"
                        },
                        new
                        {
                            FlightId = 18,
                            FlightName = "KingFisher",
                            From = "Mumbai",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Delhi"
                        },
                        new
                        {
                            FlightId = 19,
                            FlightName = "SpiceJet",
                            From = "Delhi",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Mumbai"
                        },
                        new
                        {
                            FlightId = 20,
                            FlightName = "SpiceJet",
                            From = "Mumbai",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Delhi"
                        },
                        new
                        {
                            FlightId = 21,
                            FlightName = "KingFisher",
                            From = "Delhi",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Chennai"
                        },
                        new
                        {
                            FlightId = 22,
                            FlightName = "KingFisher",
                            From = "Chennai",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Delhi"
                        },
                        new
                        {
                            FlightId = 23,
                            FlightName = "SpiceJet",
                            From = "Delhi",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Chennai"
                        },
                        new
                        {
                            FlightId = 24,
                            FlightName = "SpiceJet",
                            From = "Chennai",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Delhi"
                        },
                        new
                        {
                            FlightId = 25,
                            FlightName = "KingFisher",
                            From = "Delhi",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Jammu & Kashmir"
                        },
                        new
                        {
                            FlightId = 26,
                            FlightName = "KingFisher",
                            From = "Jammu & Kashmir",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Delhi"
                        },
                        new
                        {
                            FlightId = 27,
                            FlightName = "SpiceJet",
                            From = "Delhi",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Jammu & Kashmir"
                        },
                        new
                        {
                            FlightId = 28,
                            FlightName = "SpiceJet",
                            From = "Jammu & Kashmir",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Delhi"
                        },
                        new
                        {
                            FlightId = 29,
                            FlightName = "KingFisher",
                            From = "Mumbai",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Chennai"
                        },
                        new
                        {
                            FlightId = 30,
                            FlightName = "KingFisher",
                            From = "Chennai",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Mumbai"
                        },
                        new
                        {
                            FlightId = 31,
                            FlightName = "SpiceJet",
                            From = "Mumbai",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Chennai"
                        },
                        new
                        {
                            FlightId = 32,
                            FlightName = "SpiceJet",
                            From = "Chennai",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Mumbai"
                        },
                        new
                        {
                            FlightId = 33,
                            FlightName = "KingFisher",
                            From = "Jammu & Kashmir",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Chennai"
                        },
                        new
                        {
                            FlightId = 34,
                            FlightName = "KingFisher",
                            From = "Chennai",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Jammu & Kashmir"
                        },
                        new
                        {
                            FlightId = 35,
                            FlightName = "SpiceJet",
                            From = "Jammu & Kashmir",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Chennai"
                        },
                        new
                        {
                            FlightId = 36,
                            FlightName = "SpiceJet",
                            From = "Chennai",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Jammu & Kashmir"
                        },
                        new
                        {
                            FlightId = 37,
                            FlightName = "KingFisher",
                            From = "Jammu & Kashmir",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Mumbai"
                        },
                        new
                        {
                            FlightId = 38,
                            FlightName = "KingFisher",
                            From = "Mumbai",
                            Time = new TimeSpan(0, 10, 0, 0, 0),
                            To = "Jammu & Kashmir"
                        },
                        new
                        {
                            FlightId = 39,
                            FlightName = "SpiceJet",
                            From = "Jammu & Kashmir",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Mumbai"
                        },
                        new
                        {
                            FlightId = 40,
                            FlightName = "SpiceJet",
                            From = "Mumbai",
                            Time = new TimeSpan(0, 17, 0, 0, 0),
                            To = "Jammu & Kashmir"
                        });
                });

            modelBuilder.Entity("TravelingDiaries.Models.FlightBooking", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassengerId"), 1L, 1);

                    b.Property<string>("AdhaarId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CartID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfFlight")
                        .HasColumnType("datetime2");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<string>("PassengerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PassengerId");

                    b.HasIndex("FlightId");

                    b.ToTable("FlightBooking");
                });

            modelBuilder.Entity("TravelingDiaries.Models.Place", b =>
                {
                    b.Property<int>("PlaceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaceID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PackagePrice")
                        .HasColumnType("int");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlaceID");

                    b.ToTable("place");

                    b.HasData(
                        new
                        {
                            PlaceID = 1,
                            Description = "Jammu and Kashmir is a union territory of India.It is situated in the northernmost part of India.The main languages that are used by the people of Jammu and Kashmir are Urdu, Dogri,and Kashmiri.Vaishno Devi and Amarnath are the major Hindu pilgrim centres in Jammu and Kashmir.",
                            Image = "https://img.freepik.com/free-photo/sunrise-dal-lake-kashmir-india_1232-4765.jpg?w=740&t=st=1660742921~exp=1660743521~hmac=0923b8734ac5a6599c2586a098052333909e7042b57dfa255f6ad38608a23014",
                            Image1 = "https://static.toiimg.com/thumb/62507186.cms?resizemode=75&width=1200&height=900",
                            Image2 = "https://www.tourmyindia.com/blog//wp-content/uploads/2014/02/Top-Things-to-Do-in-Jammu-and-Kashmir.jpg",
                            Image3 = "https://assets.thehansindia.com/h-upload/2021/12/04/1125042-kashmir.webp",
                            PackagePrice = 50000,
                            PlaceName = "Jammu and Kashmir",
                            ShortDescription = "Jammu and Kashmir is a region administered by India as a union territory and consists of the southern portion of the larger Kashmir region."
                        },
                        new
                        {
                            PlaceID = 2,
                            Description = "Delhi is officially the National Capital Territory. NewDelhi is the capital of India.Delhi has an important structure like Humayun’s tomb, Old fort, Siri fort,Jama Masjid,Lotus temple monuments.Delhi – it’s not just a city but an emotion.Delhi has been the centre of a succession of mighty empires and powerful kingdoms. Numerous ruins scattered throughout the territory offer a constant reminder of the area’s history.",
                            Image = "https://cdn.britannica.com/37/189837-050-F0AF383E/New-Delhi-India-War-Memorial-arch-Sir.jpg",
                            Image1 = "http://static2.tripoto.com/media/filter/tst/img/15546/TripDocument/4126922057_8e74c08828_o.jpg",
                            Image2 = "https://cdn.britannica.com/92/189792-050-1B98CC71/Bara-Gumbad-mosque-Lodi-Gardens-Delhi.jpg",
                            Image3 = "https://media.istockphoto.com/photos/humayun-tomb-new-delhi-india-picture-id505239248?k=20&m=505239248&s=612x612&w=0&h=-VDBIaBQquH4MEiLgeCwzhndOAGhIBjKseW_trSmWqo=",
                            PackagePrice = 40000,
                            PlaceName = "Delhi",
                            ShortDescription = "Delhi is a part of the National Capital Region, which has 12.5 million residents. The governance of Delhi is like that of a state in India."
                        },
                        new
                        {
                            PlaceID = 3,
                            Description = "Jaipur, popularly known as the Pink City of India, is the largest city in the state of RajasthanJaipur is the capital of state Rajasthan The main attraction of Jaipur is its archetypal architecture. The city was planned as per the Indian Vastu Shastra, a science that promotes well being and prosperity. The directions of all the streets and markets in Jaipur are East to West and North to South.Jai Singh II made sure that the entire Jaipur city was planned as per the Hindu architectural theory. ",
                            Image = "https://static.independent.co.uk/s3fs-public/thumbnails/image/2018/08/14/09/jaipur-hawa.jpg?quality=75&width=982&height=726&auto=webp",
                            Image1 = "https://www.micato.com/wp-content/uploads/2018/09/jaipur-1110x700.jpg",
                            Image2 = "https://assets.traveltriangle.com/blog/wp-content/uploads/2016/09/jal-mahal-cover-439.jpg",
                            Image3 = "https://image.shutterstock.com/image-photo/ancient-temple-ruins-gadi-sagar-260nw-786126286.jpg",
                            PackagePrice = 25000,
                            PlaceName = "Jaipur",
                            ShortDescription = " Across the entire Rajasthan, Jaipur is known to be the biggest city. It is also popularly called the Pink City."
                        },
                        new
                        {
                            PlaceID = 4,
                            Description = "Mumbai was previously known as Bombay and it is the capital of Maharashtra.Mumbai is one of India’s largest cities which is also the financial and entertainment capital of India.Marathi is the main language of the state and Kabadi is the state sport.Gateway of India is the symbol of Mumbai.It is the tourists’ centre.One of the most iconic hotels of India, the Taj Mahal Palace is located in Mumbai.It is famous for Chhatrapati Shivaji Terminus.The city is known for its popular nightlife.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Marine_Lines_Mumbai_2021.jpg/800px-Marine_Lines_Mumbai_2021.jpg",
                            Image1 = "https://www.holidify.com/images/bgImages/MUMBAI.jpg",
                            Image2 = "https://images.unsplash.com/photo-1529253355930-ddbe423a2ac7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8bXVtYmFpfGVufDB8fDB8fA%3D%3D&w=1000&q=80",
                            Image3 = "https://assets.gqindia.com/photos/5f4df431de5e2aaea53dd83d/2:3/w_719,h_1079,c_limit/The-most-expensive-residential-spots-in-Mumbai-where-1-square-feet-costs-upwards-of-Rs-40,000.jpg",
                            PackagePrice = 30000,
                            PlaceName = "Mumbai",
                            ShortDescription = "Mumbai (formerly called Bombay) is a densely populated city on India’s west coast."
                        },
                        new
                        {
                            PlaceID = 5,
                            Description = "Chennai,formerly Madras,city,capital of Tamil Nadu state,southern India,located on the Coromandel Coast of the Bay of Bengal.Known as the “Gateway to South India,”Chennai is located on the Coromandel Coast along the Bay of Bengal.It is included as one of the four metropolitan siblings of the country.It has a cultural and historical background that is both rich and vast.It thoroughly mixes up with the metropolis lifestyle perfectly.Besides,it is very famous for its South-Indian culture, museums from the British Era, monuments, temples, and so on.",
                            Image = "https://media.istockphoto.com/photos/detail-work-in-gopuram-hindu-temple-kapaleeshwarar-chennai-tamil-nadu-picture-id808900036?k=20&m=808900036&s=612x612&w=0&h=NLkFUtqGEnBgiSbtlhBF02CiZD9NZXbE0f3vccIwVnk=",
                            Image1 = "https://www.tralover.com/uploads/0000/1/2021/11/10/47193d1364680014c23ad25ff3b7e433.jpg",
                            Image2 = "https://upload.wikimedia.org/wikipedia/commons/3/32/Chennai_Central.jpg",
                            Image3 = "https://cdn.britannica.com/13/100813-050-708D93FE/Kapaleeswarar-temple-Hindu-Mylapore-Chennai-India-Tamil.jpg",
                            PackagePrice = 10000,
                            PlaceName = "Chennai",
                            ShortDescription = " Chennai used to be known as Madras. It is considered as the capital of Tamil Nadu in the southern side of India."
                        });
                });

            modelBuilder.Entity("TravelingDiaries.Models.SearchFlight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SearchFlights");
                });

            modelBuilder.Entity("TravelingDiaries.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartItemId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("PlaceID")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("PlaceID");

                    b.ToTable("shoppingCartItems");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelingDiaries.Models.FlightBooking", b =>
                {
                    b.HasOne("TravelingDiaries.Models.Flight", "FlightInfo")
                        .WithMany()
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FlightInfo");
                });

            modelBuilder.Entity("TravelingDiaries.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("TravelingDiaries.Models.Place", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");
                });
#pragma warning restore 612, 618
        }
    }
}
