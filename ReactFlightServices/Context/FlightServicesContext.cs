using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ReactFlightServices.Context.Entities;

namespace ReactFlightServices.Context
{
    public partial class FlightServicesContext : DbContext
    {
        public FlightServicesContext()
        {
        }

        public FlightServicesContext(DbContextOptions<FlightServicesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airport> Airports { get; set; } = null!;
        public virtual DbSet<Crew> Crews { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<FlightGate> FlightGates { get; set; } = null!;
        public virtual DbSet<Gate> Gates { get; set; } = null!;
        public virtual DbSet<Passenger> Passengers { get; set; } = null!;
        public virtual DbSet<PassengerTicket> PassengerTickets { get; set; } = null!;
        public virtual DbSet<Pilot> Pilots { get; set; } = null!;
        public virtual DbSet<Terminal> Terminals { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<TicketClerk> TicketClerks { get; set; } = null!;
        public virtual DbSet<TicketClerkTicket> TicketClerkTickets { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FlightServicesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>(entity =>
            {
                entity.ToTable("Airport");

                entity.Property(e => e.AirportCity).HasMaxLength(50);

                entity.Property(e => e.AirportName).HasMaxLength(128);
            });

            modelBuilder.Entity<Crew>(entity =>
            {
                entity.ToTable("Crew");

                entity.Property(e => e.CrewAddress).HasMaxLength(128);

                entity.Property(e => e.CrewCity).HasMaxLength(50);

                entity.Property(e => e.CrewEmail).HasMaxLength(50);

                entity.Property(e => e.CrewFirst).HasMaxLength(50);

                entity.Property(e => e.CrewLast).HasMaxLength(50);

                entity.Property(e => e.CrewMiddle).HasMaxLength(50);

                entity.Property(e => e.CrewPhone).HasMaxLength(50);

                entity.Property(e => e.CrewState).HasMaxLength(50);

                entity.Property(e => e.CrewZip).HasMaxLength(10);
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("Flight");

                entity.Property(e => e.FlightDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlightName).HasMaxLength(50);
            });

            modelBuilder.Entity<FlightGate>(entity =>
            {
                entity.ToTable("FlightGate");

                entity.Property(e => e.FlightGateId).ValueGeneratedNever();

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.FlightGates)
                    .HasForeignKey(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightGate_Flight");

                entity.HasOne(d => d.Gate)
                    .WithMany(p => p.FlightGates)
                    .HasForeignKey(d => d.GateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightGate_Gate");
            });

            modelBuilder.Entity<Gate>(entity =>
            {
                entity.ToTable("Gate");

                entity.Property(e => e.GateTerminal)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.ToTable("Passenger");

                entity.Property(e => e.Address).HasMaxLength(128);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(16);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<PassengerTicket>(entity =>
            {
                entity.ToTable("PassengerTicket");

                entity.Property(e => e.PassengerTicketId).ValueGeneratedNever();

                entity.HasOne(d => d.Passenger)
                    .WithMany(p => p.PassengerTickets)
                    .HasForeignKey(d => d.PassengerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassengerTicket_Passenger");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.PassengerTickets)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassengerTicket_Ticket");
            });

            modelBuilder.Entity<Pilot>(entity =>
            {
                entity.ToTable("Pilot");

                entity.Property(e => e.Address).HasMaxLength(128);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PilotEmail)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Terminal>(entity =>
            {
                entity.ToTable("Terminal");

                entity.Property(e => e.TerminalDesc).HasMaxLength(512);

                entity.Property(e => e.TerminalName).HasMaxLength(50);

                entity.HasOne(d => d.Airport)
                    .WithMany(p => p.Terminals)
                    .HasForeignKey(d => d.AirportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terminal_Airport");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.TicketDate).HasColumnType("datetime");

                entity.Property(e => e.TicketNumber).HasMaxLength(5);

                entity.Property(e => e.TicketPrice).HasColumnType("money");

                entity.HasOne(d => d.TicketFlightNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.TicketFlight)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_Flight");
            });

            modelBuilder.Entity<TicketClerk>(entity =>
            {
                entity.HasKey(e => e.ClerkId)
                    .HasName("PK__TicketCl__4F0B1187BCD7C7FA");

                entity.ToTable("TicketClerk");

                entity.Property(e => e.ClerkAddress).HasMaxLength(128);

                entity.Property(e => e.ClerkCity).HasMaxLength(50);

                entity.Property(e => e.ClerkFirst).HasMaxLength(50);

                entity.Property(e => e.ClerkLast).HasMaxLength(50);

                entity.Property(e => e.ClerkMiddle).HasMaxLength(50);

                entity.Property(e => e.ClerkState).HasMaxLength(50);

                entity.Property(e => e.ClerkZip).HasMaxLength(10);

                entity.HasOne(d => d.ClerkAirportNavigation)
                    .WithMany(p => p.TicketClerks)
                    .HasForeignKey(d => d.ClerkAirport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketClerk_AIrport");
            });

            modelBuilder.Entity<TicketClerkTicket>(entity =>
            {
                entity.HasKey(e => e.ClerkTicketsId)
                    .HasName("PK__TicketCl__DC58442AB833EE62");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketClerkTickets)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClerkTickets_Ticket");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.VendorDesc).HasMaxLength(256);

                entity.Property(e => e.VendorName).HasMaxLength(50);

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.TerminalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vendor_Terminal");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
