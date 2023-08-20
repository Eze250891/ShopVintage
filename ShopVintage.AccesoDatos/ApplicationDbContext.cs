using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VintageShop.Entidades;

namespace ShopVintage.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Zapato> Zapatos { get; set; }
        public DbSet<Talle> Talles { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<FormaDePago> FormaDePagos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Stock> Stocks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //--------Usuarios--------
            modelBuilder.Entity<Usuario>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Nombre)
                .IsRequired();

            modelBuilder.Entity<Usuario>()
                .Property(x => x.Apellido)
                .IsRequired();

            modelBuilder.Entity<Usuario>()
               .Property(x => x.Email)
               .IsRequired();


            //--------Zapato--------

            modelBuilder.Entity<Zapato>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Zapato>()
               .Property(x => x.IdMarca);

            modelBuilder.Entity<Zapato>()
               .Property(x => x.Modelo)
               .IsRequired();

            modelBuilder.Entity<Zapato>()
               .Property(x => x.Precio)
               .IsRequired();

            modelBuilder.Entity<Zapato>()
               .Property(x => x.Imagen);

            modelBuilder.Entity<Zapato>()
                        .HasOne(x => x.Marca)
                        .WithMany(m => m.ZapatosList)
                        .HasForeignKey(x => x.IdMarca);

            //modelBuilder.Entity<Zapato>()
            //            .HasOne(x => x.ta)
            //            .WithMany(m => );



            //--------Talle--------

            modelBuilder.Entity<Talle>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Talle>()
                .Property(x => x.IdZapato);

            modelBuilder.Entity<Talle>()
                .Property(x => x.TalleNumero);


            modelBuilder.Entity<Talle>()
                        .HasOne(x => x.ZapatoUnico)
                        .WithMany(m => m.Talles)
                        .HasForeignKey(x => x.IdZapato);


            //--------Pago--------

            modelBuilder.Entity<Pago>()
                        .HasKey(x => x.Id);

            modelBuilder.Entity<Pago>()
                        .Property(x => x.IdFormaDePago);

            modelBuilder.Entity<Pago>()
                        .Property(x => x.IdPrecioZapato);


            modelBuilder.Entity<Pago>()
                        .HasOne(fp => fp.FormaDePago)
                        .WithMany(fp => fp.Pagos)
                        .HasForeignKey(x => x.IdFormaDePago);

            modelBuilder.Entity<Pago>()
                        .HasOne(z => z.ZapatoAPagar)
                        .WithMany(p => p.PagosList)
                        .HasForeignKey(x => x.IdPrecioZapato);

            //--------FormaDePago--------

            modelBuilder.Entity<FormaDePago>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<FormaDePago>()
                .Property(x => x.Descripcion)
                .IsRequired();

            //--------Marca--------

            modelBuilder.Entity<Marca>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Marca>()
                .Property(x => x.Nombre)
                .IsRequired();

            //--------Stock--------

            modelBuilder.Entity<Stock>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Stock>()
                .Property(x => x.IdZapato)
                .IsRequired();

            modelBuilder.Entity<Stock>()
                .Property(x => x.IdTalle)
                .IsRequired();

            modelBuilder.Entity<Stock>()
                .Property(x => x.Cantidad)
                .IsRequired();

            modelBuilder.Entity<Stock>()
                        .HasOne(z => z.ZapatoStock)
                        .WithMany(s => s.StocksList)
                        .HasForeignKey(t => t.IdZapato);

            modelBuilder.Entity<Stock>()
                        .HasOne(z => z.TalleStock)
                        .WithMany(s => s.StocksList)
                        .HasForeignKey(t => t.IdTalle);

        }
    }
}
    
