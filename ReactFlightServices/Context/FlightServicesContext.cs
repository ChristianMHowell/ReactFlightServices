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

        public virtual DbSet<Airline> Airlines { get; set; } = null!;
        public virtual DbSet<Airport> Airports { get; set; } = null!;
        public virtual DbSet<AirportManager> AirportManagers { get; set; } = null!;
        public virtual DbSet<Crew> Crews { get; set; } = null!;
        public virtual DbSet<CrewAirline> CrewAirlines { get; set; } = null!;
        public virtual DbSet<CrewFlight> CrewFlights { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<FlightGate> FlightGates { get; set; } = null!;
        public virtual DbSet<FlightPilot> FlightPilots { get; set; } = null!;
        public virtual DbSet<FlightStatusType> FlightStatusTypes { get; set; } = null!;
        public virtual DbSet<Gate> Gates { get; set; } = null!;
        public virtual DbSet<Passenger> Passengers { get; set; } = null!;
        public virtual DbSet<PassengerTicket> PassengerTickets { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Pilot> Pilots { get; set; } = null!;
        public virtual DbSet<Terminal> Terminals { get; set; } = null!;
        public virtual DbSet<TicektPayment> TicektPayments { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<TicketClerk> TicketClerks { get; set; } = null!;
        public virtual DbSet<TicketClerkTicket> TicketClerkTickets { get; set; } = null!;
        public virtual DbSet<TicketPayment> TicketPayments { get; set; } = null!;
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
            modelBuilder.Entity<Airline>(entity =>
            {
                entity.ToTable("Airline");

                entity.Property(e => e.AirlineAddress).HasMaxLength(128);

                entity.Property(e => e.AirlineCity).HasMaxLength(64);

                entity.Property(e => e.AirlineName).HasMaxLength(50);
            });

            modelBuilder.Entity<Airport>(entity =>
            {
                entity.ToTable("Airport");

                entity.Property(e => e.AirportCity).HasMaxLength(50);

                entity.Property(e => e.AirportName).HasMaxLength(128);

                entity.Property(e => e.TimeClose).HasColumnType("time(2)");

                entity.Property(e => e.TimeOpen).HasColumnType("time(2)");
            });

            modelBuilder.Entity<AirportManager>(entity =>
            {
                entity.HasKey(e => e.ManagerId)
                    .HasName("PK__AirportM__3BA2AAE1387FA0EC");

                entity.ToTable("AirportManager");

                entity.Property(e => e.ManagerAddress).HasMaxLength(50);

                entity.Property(e => e.ManagerCity).HasMaxLength(50);

                entity.Property(e => e.ManagerFirst).HasMaxLength(50);

                entity.Property(e => e.ManagerLast).HasMaxLength(50);

                entity.Property(e => e.ManagerMiddle).HasMaxLength(50);

                entity.Property(e => e.ManagerState).HasMaxLength(50);

                entity.Property(e => e.ManagerZip).HasMaxLength(10);

                entity.HasOne(d => d.ManagerAirportNavigation)
                    .WithMany(p => p.AirportManagers)
                    .HasForeignKey(d => d.ManagerAirport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AirportManager_Airport");
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

            modelBuilder.Entity<CrewAirline>(entity =>
            {
                entity.HasKey(e => e.AirlineCrewId)
                    .HasName("PK__CrewAirl__47880D31A1809E9E");

                entity.ToTable("CrewAirline");

                entity.HasOne(d => d.Airline)
                    .WithMany(p => p.CrewAirlines)
                    .HasForeignKey(d => d.AirlineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrewAirline_Airline");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewAirlines)
                    .HasForeignKey(d => d.CrewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrewAirline_Crew");
            });

            modelBuilder.Entity<CrewFlight>(entity =>
            {
                entity.HasKey(e => e.CrewFilghtId)
                    .HasName("PK__CrewFlig__45D0093AC59031A8");

                entity.ToTable("CrewFlight");

                entity.HasOne(d => d.Crew)
                    .WithMany(p => p.CrewFlights)
                    .HasForeignKey(d => d.CrewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrewFlight_Crew");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.CrewFlights)
                    .HasForeignKey(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrewFlight_Flight");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("Flight");

                entity.Property(e => e.FlightDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlightName).HasMaxLength(50);

                entity.HasOne(d => d.FlightAirlineNavigation)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.FlightAirline)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Flight_Airline");

                entity.HasOne(d => d.FlightStatusNavigation)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.FlightStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Flight_FlightStatus");
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

            modelBuilder.Entity<FlightPilot>(entity =>
            {
                entity.HasKey(e => e.PilotFlightId)
                    .HasName("PK__FlightPi__C5981F96B3104EFA");

                entity.ToTable("FlightPilot");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.FlightPilots)
                    .HasForeignKey(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightPilot_Flight");

                entity.HasOne(d => d.Pilot)
                    .WithMany(p => p.FlightPilots)
                    .HasForeignKey(d => d.PilotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightPilot_Pilot");
            });

            modelBuilder.Entity<FlightStatusType>(entity =>
            {
                entity.HasKey(e => e.FlightStatusId)
                    .HasName("PK__FlightSt__A09ECC7D5A11CF35");

                entity.ToTable("FlightStatusType");

                entity.Property(e => e.StatusName).HasMaxLength(50);
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

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentCode).HasMaxLength(8);

                entity.Property(e => e.PaymentExpire).HasColumnType("date");

                entity.Property(e => e.PaymentNumber).HasMaxLength(50);

                entity.Property(e => e.PaymentType).HasMaxLength(20);

                entity.HasOne(d => d.PaymentPassengerNavigation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentPassenger)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Passenger");
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

            modelBuilder.Entity<TicektPayment>(entity =>
            {
                entity.HasKey(e => e.TicketPaymentId)
                    .HasName("PK__TicektPa__04E8446564E127DA");

                entity.ToTable("TicektPayment");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.TicketDate).HasColumnType("datetime");

                entity.Property(e => e.TicketNumber).HasMaxLength(5);

                entity.Property(e => e.TicketPrice).HasColumnType("money");

                entity.Property(e => e.TicketSeat)
                    .HasMaxLength(1)
                    .IsFixedLength();

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

            modelBuilder.Entity<TicketPayment>(entity =>
            {
                entity.ToTable("TicketPayment");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.TicketPayments)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketPayment_Payment");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketPayments)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketPayment_Ticket");
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
