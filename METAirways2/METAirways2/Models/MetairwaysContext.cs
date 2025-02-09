using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace METAirways2.Models;

public partial class MetairwaysContext : DbContext
{
    public MetairwaysContext()
    {
    }

    public MetairwaysContext(DbContextOptions<MetairwaysContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Flight> Flights { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Flight>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Flight");

            entity.Property(e => e.FlightDate).HasColumnType("datetime");
            entity.Property(e => e.FlightId).HasColumnName("FlightID");
            entity.Property(e => e.FlightName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FlightType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
