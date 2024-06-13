using System;
using System.Collections.Generic;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess;

public partial class FlightManagementDbContext : DbContext
{
    public FlightManagementDbContext()
    {
    }

    public FlightManagementDbContext(DbContextOptions<FlightManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Airline> Airlines { get; set; }

    public virtual DbSet<Airport> Airports { get; set; }

    public virtual DbSet<Baggage> Baggages { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookingPlatform> BookingPlatforms { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<Passenger> Passengers { get; set; }


	private static string GetConnectionString()
	{
		IConfiguration configuration = new ConfigurationBuilder().
			SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.josn", true, true).Build();
		return configuration.GetConnectionString("DefaultConnection");
	}
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Airline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__airline__3213E83F1A3FEB8B");

            entity.ToTable("airline");

            entity.HasIndex(e => e.Code, "UQ__airline__357D4CF917A77F19").IsUnique();

            entity.HasIndex(e => e.Name, "UQ__airline__72E12F1B6F3D7719").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Airport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__airport__3213E83FC78BE352");

            entity.ToTable("airport");

            entity.HasIndex(e => e.Code, "UQ__airport__357D4CF9CCAFDB03").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
        });

        modelBuilder.Entity<Baggage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__baggage__3213E83FE60A7BBB");

            entity.ToTable("baggage");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BookingId).HasColumnName("booking_id");
            entity.Property(e => e.WeightInKg)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("weight_in_kg");

            entity.HasOne(d => d.Booking).WithMany(p => p.Baggages)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK__baggage__booking__38996AB5");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__booking__3213E83F621387C2");

            entity.ToTable("booking");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BookingPlatformId).HasColumnName("booking_platform_id");
            entity.Property(e => e.BookingTime)
                .HasColumnType("datetime")
                .HasColumnName("booking_time");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.PassengerId).HasColumnName("passenger_id");

            entity.HasOne(d => d.BookingPlatform).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.BookingPlatformId)
                .HasConstraintName("FK__booking__booking__35BCFE0A");

            entity.HasOne(d => d.Flight).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK__booking__flight___34C8D9D1");

            entity.HasOne(d => d.Passenger).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.PassengerId)
                .HasConstraintName("FK__booking__passeng__33D4B598");
        });

        modelBuilder.Entity<BookingPlatform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__bookingP__3213E83FA4FEFCB0");

            entity.ToTable("bookingPlatform");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__flight__3213E83FC8BA2BED");

            entity.ToTable("flight");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.ArrivalTime)
                .HasColumnType("datetime")
                .HasColumnName("arrival_time");
            entity.Property(e => e.ArrivingAirport).HasColumnName("arriving_airport");
            entity.Property(e => e.ArrivingGate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("arriving_gate");
            entity.Property(e => e.DepartingAirport).HasColumnName("departing_airport");
            entity.Property(e => e.DepartingGate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("departing_gate");
            entity.Property(e => e.DepartureTime)
                .HasColumnType("datetime")
                .HasColumnName("departure_time");

            entity.HasOne(d => d.Airline).WithMany(p => p.Flights)
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("FK__flight__airline___2B3F6F97");

            entity.HasOne(d => d.ArrivingAirportNavigation).WithMany(p => p.FlightArrivingAirportNavigations)
                .HasForeignKey(d => d.ArrivingAirport)
                .HasConstraintName("FK__flight__arriving__2D27B809");

            entity.HasOne(d => d.DepartingAirportNavigation).WithMany(p => p.FlightDepartingAirportNavigations)
                .HasForeignKey(d => d.DepartingAirport)
                .HasConstraintName("FK__flight__departin__2C3393D0");
        });

        modelBuilder.Entity<Passenger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__passenge__3213E83F177E68D6");

            entity.ToTable("passenger");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
