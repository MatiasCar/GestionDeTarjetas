using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GestionDeTarjetas.Models
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
        {
        }

        public ContextDB(DbContextOptions<ContextDB> options)
            : base(options)
        {
        }

        public virtual DbSet<CCOB_CLIE> CCOB_CLIE { get; set; } = null!;
        public virtual DbSet<CCOB_CLPF> CCOB_CLPF { get; set; } = null!;
        public virtual DbSet<CCOB_CTEC> CCOB_CTEC { get; set; } = null!;
        public virtual DbSet<CCOB_CVCC> CCOB_CVCC { get; set; } = null!;
        public virtual DbSet<CCOB_CVCL> CCOB_CVCL { get; set; } = null!;
        public virtual DbSet<CCOB_RCCL> CCOB_RCCL { get; set; } = null!;
        public virtual DbSet<CCOB_TCBR> CCOB_TCBR { get; set; } = null!;
        public virtual DbSet<CCOB_TCBV> CCOB_TCBV { get; set; } = null!;
        public virtual DbSet<CCOB_TCCB> CCOB_TCCB { get; set; } = null!;
        public virtual DbSet<CCOB_VCTC> CCOB_VCTC { get; set; } = null!;
        public virtual DbSet<CONT_CUEN> CONT_CUEN { get; set; } = null!;
        public virtual DbSet<DMCOBRADOR> DMCOBRADOR { get; set; } = null!;
        public virtual DbSet<DMCTA_CONT> DMCTA_CONT { get; set; } = null!;
        public virtual DbSet<DMED_TARJ> DMED_TARJ { get; set; } = null!;
        public virtual DbSet<DMPARM_CONF> DMPARM_CONF { get; set; } = null!;
        public virtual DbSet<DMTIPO_FACT> DMTIPO_FACT { get; set; } = null!;
        public virtual DbSet<DMTIPO_RECI> DMTIPO_RECI { get; set; } = null!;
        public virtual DbSet<SIST_COBR> SIST_COBR { get; set; } = null!;
        public virtual DbSet<dmLOTE_COMPROBANTES> dmLOTE_COMPROBANTES { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=vserver112;Database=DBBET_EL_IAQ;UID=sa;PWD=sasa;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CCOB_CLIE>(entity =>
            {
                entity.HasKey(e => e.CLIE_CLIENTE)
                    .HasName("CLIE_PK1")
                    .IsClustered(false);

                entity.HasIndex(e => e.CLIE_CUIT, "CLIE_IE1");

                entity.HasIndex(e => e.CLIE_CLIENTE_EXT, "CLIE_IE2");

                entity.Property(e => e.CLIE_CLIENTE).ValueGeneratedNever();

                entity.Property(e => e.CLIE_ACTIVIDAD_CLI)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_BARRIO)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_BLOQUEADO_FAC).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CLIE_BLOQUEADO_PED).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CLIE_CALLE)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_1)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_3)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_4)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_5)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_6)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_7)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_8)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_9)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_NPCV_1)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_NPCV_2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_NPCV_3)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_NPCV_4)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_NPCV_5)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLASIF_NPCV_6)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CLIENTE_EXT)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_COBRADOR)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_COBRO_CORREL).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CLIE_COD_CALLE)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_COD_POSTAL)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_COD_PROVEEDOR)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CONDICION_IVA)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_COND_PAGO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CONTAC_COBRO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CONTAC_VENTA)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CUENTA_CLIE)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_CUIT)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_DEPTO)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_DISTRIBUIDOR)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_DOMICILIO)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_ECM_ASUNTO)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_ECM_EMAIL)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_EMAIL)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_ERM_ASUNTO)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_ERM_EMAIL)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_ES_CLI_GLOB).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CLIE_FACT_CRED_ELEC_CIRCUITO_DE_PAGO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_FACT_CRED_ELEC_MONTO_MIN_LOCAL).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CLIE_FAX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_FECHA_1).HasColumnType("datetime");

                entity.Property(e => e.CLIE_FECHA_2).HasColumnType("datetime");

                entity.Property(e => e.CLIE_FECHA_3).HasColumnType("datetime");

                entity.Property(e => e.CLIE_FECHA_4).HasColumnType("datetime");

                entity.Property(e => e.CLIE_FECHA_ALTA).HasColumnType("datetime");

                entity.Property(e => e.CLIE_FECHA_BAJA).HasColumnType("datetime");

                entity.Property(e => e.CLIE_FECHA_PROX_GC).HasColumnType("datetime");

                entity.Property(e => e.CLIE_FLETE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_FORMATO_FIMC)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_HABIL_CC_CLIE).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CLIE_HABIL_WEB).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CLIE_HORA_ATENCION)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_HORA_ENTREGA)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_HORA_PROX_GC).HasColumnType("datetime");

                entity.Property(e => e.CLIE_INF_TABASTO).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CLIE_ING_BRUTOS)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_LOCALIDAD)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_LOGOTIPO_NOM_ALMAC)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_LOGOTIPO_NOM_ORI)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_MONEDA_CTE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_MUNICIPIO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_NODO_ORIGEN)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_NOMBRE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_NOMBRE_LEGAL)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_OBSERVACION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_PAIS)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_PASSWORD_WEB)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_PISO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_PROVINCIA)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_PROX_GES_COBR)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_REFERENCIA)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_SITIO_WEB)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_STRING_1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_STRING_2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_STRING_3)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_STRING_4)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_TASA_MENS_INTERES).HasColumnType("decimal(6, 4)");

                entity.Property(e => e.CLIE_TELEFONO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_TIPO_CLI)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_VEHICULO)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_VENDEDOR)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_VENDEDOR_2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_ZONA_DISTRIB)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CLIE_ZONA_VENTA)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.CLIE_COBRADORNavigation)
                    .WithMany(p => p.CCOB_CLIE)
                    .HasForeignKey(d => d.CLIE_COBRADOR)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COBR_R01");

                entity.HasOne(d => d.CLIE_CUENTA_CLIENavigation)
                    .WithMany(p => p.CCOB_CLIE)
                    .HasForeignKey(d => d.CLIE_CUENTA_CLIE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CUEN_R32");
            });

            modelBuilder.Entity<CCOB_CLPF>(entity =>
            {
                entity.HasKey(e => e.CLPF_CLIENTE)
                    .HasName("CLPF_PK1")
                    .IsClustered(false);

                entity.Property(e => e.CLPF_CLIENTE).ValueGeneratedNever();

                entity.Property(e => e.CLPF_FECHA_NACIM).HasColumnType("datetime");

                entity.Property(e => e.CLPF_FVTO_TARJ_CRE).HasColumnType("datetime");

                entity.Property(e => e.CLPF_NACIONALIDAD)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLPF_NRO_TARJ_CRE)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CLPF_PAIS_NACIM)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CLPF_PROFESION)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CLPF_SEXO)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CLPF_TIPO_DOC)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.CLPF_CLIENTENavigation)
                    .WithOne(p => p.CCOB_CLPF)
                    .HasForeignKey<CCOB_CLPF>(d => d.CLPF_CLIENTE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CLIE_R39");
            });

            modelBuilder.Entity<CCOB_CTEC>(entity =>
            {
                entity.HasKey(e => e.CTEC_CTACTE_CTEC)
                    .HasName("CTEC_PK1")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CTEC_CLIENTE, e.CTEC_FECHA_EMI }, "CTEC_IE1");

                entity.HasIndex(e => new { e.CTEC_CLIENTE_VENTA, e.CTEC_FECHA_EMI }, "CTEC_IE2");

                entity.Property(e => e.CTEC_CTACTE_CTEC).ValueGeneratedNever();

                entity.Property(e => e.CTEC_CONDICION_IVA)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CTEC_COND_PAGO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CTEC_COTIZACION).HasColumnType("decimal(14, 5)");

                entity.Property(e => e.CTEC_DISCRIMIN_IMP).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CTEC_ES_DIF_CAMBIO).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CTEC_FECHA_EMI).HasColumnType("datetime");

                entity.Property(e => e.CTEC_FECHA_PROX_GC).HasColumnType("datetime");

                entity.Property(e => e.CTEC_FEC_CC_CTACTE).HasColumnType("datetime");

                entity.Property(e => e.CTEC_GESTION_COBR)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CTEC_HORA_PROX_GC).HasColumnType("datetime");

                entity.Property(e => e.CTEC_IMP_BRU_LOC).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CTEC_IMP_BRU_ORI).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CTEC_IMP_CC_CTACTE).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CTEC_IMP_TOT_LOC).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CTEC_IMP_TOT_ORI).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CTEC_LETRA)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CTEC_MONEDA)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CTEC_ORIGEN)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CTEC_ORIGEN_CVCL)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CTEC_SIGNO)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CTEC_CLIENTENavigation)
                    .WithMany(p => p.CCOB_CTECCTEC_CLIENTENavigation)
                    .HasForeignKey(d => d.CTEC_CLIENTE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CLIE_R06");

                entity.HasOne(d => d.CTEC_CLIENTE_VENTANavigation)
                    .WithMany(p => p.CCOB_CTECCTEC_CLIENTE_VENTANavigation)
                    .HasForeignKey(d => d.CTEC_CLIENTE_VENTA)
                    .HasConstraintName("CLIE_R07");
            });

            modelBuilder.Entity<CCOB_CVCC>(entity =>
            {
                entity.HasKey(e => e.CVCC_CTACTE_CTEC)
                    .HasName("CVCC_PK1")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CVCC_DIVISION_CVCL, e.CVCC_SUCURSAL_CVCL, e.CVCC_TIPO_CVCL, e.CVCC_NUMERO_CVCL }, "CVCC_AK1")
                    .IsUnique();

                entity.Property(e => e.CVCC_CTACTE_CTEC).ValueGeneratedNever();

                entity.Property(e => e.CVCC_NUMERO_CVCL).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.CVCC_TIPO_CVCL)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.CVCC_CTACTE_CTECNavigation)
                    .WithOne(p => p.CCOB_CVCC)
                    .HasForeignKey<CCOB_CVCC>(d => d.CVCC_CTACTE_CTEC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CTEC_R01");

                entity.HasOne(d => d.CVCC_)
                    .WithOne(p => p.CCOB_CVCC)
                    .HasForeignKey<CCOB_CVCC>(d => new { d.CVCC_DIVISION_CVCL, d.CVCC_SUCURSAL_CVCL, d.CVCC_TIPO_CVCL, d.CVCC_NUMERO_CVCL })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CVCL_R02");
            });

            modelBuilder.Entity<CCOB_CVCL>(entity =>
            {
                entity.HasKey(e => new { e.CVCL_DIVISION_CVCL, e.CVCL_SUCURSAL_IMP, e.CVCL_TIPO_VAR, e.CVCL_NUMERO_CVCL })
                    .HasName("CVCL_PK1")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CVCL_FECHA_EMI, e.CVCL_CLIENTE }, "CVCL_IE1");

                entity.HasIndex(e => e.CVCL_NUMINT_PACA, "CVCL_IFK1");

                entity.Property(e => e.CVCL_TIPO_VAR)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_NUMERO_CVCL).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.CVCL_CALCGR_IMP_IT).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CVCL_CAMPO_OPCIONAL_FE).IsUnicode(false);

                entity.Property(e => e.CVCL_CLASIF_NPCV_1)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_CLASIF_NPCV_2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_CLASIF_NPCV_3)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_CLASIF_NPCV_4)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_CLASIF_NPCV_5)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_CLASIF_NPCV_6)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_COE).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.CVCL_COE_FECHA_ANULACION).HasColumnType("datetime");

                entity.Property(e => e.CVCL_COE_FECHA_AUTORIZACION).HasColumnType("datetime");

                entity.Property(e => e.CVCL_COMPROBANTE_CRED_ELECT).HasDefaultValueSql("((0))");

                entity.Property(e => e.CVCL_ECM_FH_ENVIO).HasColumnType("datetime");

                entity.Property(e => e.CVCL_ESTADO_CPBTE_ELEC)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CVCL_ES_MOV_CHEQUE_RECHAZADO).HasDefaultValueSql("((0))");

                entity.Property(e => e.CVCL_ES_ND_INTERES).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CVCL_FACT_CRED_ELEC_ANUL_COMPR_RECH).HasDefaultValueSql("((0))");

                entity.Property(e => e.CVCL_FACT_CRED_ELEC_CIRCUITO_DE_PAGO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_FACT_CRED_ELEC_MONTO_MIN_LOC).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CVCL_FECHA_ASOCIADA_DESDE).HasColumnType("datetime");

                entity.Property(e => e.CVCL_FECHA_ASOCIADA_HASTA).HasColumnType("datetime");

                entity.Property(e => e.CVCL_FECHA_BAJA).HasColumnType("datetime");

                entity.Property(e => e.CVCL_FECHA_DES_PREST_SERVICIOS).HasColumnType("datetime");

                entity.Property(e => e.CVCL_FECHA_EMI).HasColumnType("datetime");

                entity.Property(e => e.CVCL_FECHA_HAS_PREST_SERVICIOS).HasColumnType("datetime");

                entity.Property(e => e.CVCL_FECHA_IMPRESO).HasColumnType("datetime");

                entity.Property(e => e.CVCL_FECHA_VTO_CAI).HasColumnType("datetime");

                entity.Property(e => e.CVCL_FEC_ENT_VAL).HasColumnType("datetime");

                entity.Property(e => e.CVCL_FEC_PROCESO_CAE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_IMP_FISCAL).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CVCL_INC_MULTINODO).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CVCL_NODO_ORIGEN)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_NUFEC_VTO_FIN).HasColumnType("datetime");

                entity.Property(e => e.CVCL_NUFEC_VTO_INT).HasColumnType("datetime");

                entity.Property(e => e.CVCL_NUMERADOR)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_NUMERO_CAI)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_OPER_NGV_AFIP)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_ORIGEN)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_REFERENCIA_1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_REFERENCIA_2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_REFERENCIA_3)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_REF_PREF_DEPU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CVCL_TASA_INT_MES).HasColumnType("decimal(6, 4)");

                entity.HasOne(d => d.CVCL_CLIENTENavigation)
                    .WithMany(p => p.CCOB_CVCL)
                    .HasForeignKey(d => d.CVCL_CLIENTE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CLIE_R12");

                entity.HasOne(d => d.CVCL_TIPO_VARNavigation)
                    .WithMany(p => p.CCOB_CVCL)
                    .HasForeignKey(d => d.CVCL_TIPO_VAR)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TCBV_R01");
            });

            modelBuilder.Entity<CCOB_RCCL>(entity =>
            {
                entity.HasKey(e => new { e.RCCL_DIVISION_RCCL, e.RCCL_SUCURSAL_IMP, e.RCCL_TIPO_REC, e.RCCL_NUMERO_RCCL })
                    .HasName("RCCL_PK1")
                    .IsClustered(false);

                entity.Property(e => e.RCCL_TIPO_REC)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RCCL_NUMERO_RCCL).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.RCCL_COBRADOR)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RCCL_COTIZACION_PROMEDIO).HasColumnType("decimal(14, 5)");

                entity.Property(e => e.RCCL_CUENTA_DTOS)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RCCL_ERM_FH_ENVIO).HasColumnType("datetime");

                entity.Property(e => e.RCCL_FECHA_BAJA).HasColumnType("datetime");

                entity.Property(e => e.RCCL_FECHA_EMI).HasColumnType("datetime");

                entity.Property(e => e.RCCL_IMP_CTA_LOC).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.RCCL_IMP_CTA_ORI).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.RCCL_INC_MULTINODO).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.RCCL_NODO_ORIGEN)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RCCL_NRO_FC_CDO).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.RCCL_REF_CLIENTE)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RCCL_REF_SCOB_DEPU)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RCCL_REQ_SOLIC_COB).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.RCCL_TIPO_FC_CDO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RCCL_TOT_DTOS_LOC).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.RCCL_TOT_DTOS_ORI).HasColumnType("decimal(14, 2)");

                entity.HasOne(d => d.RCCL_CLIENTENavigation)
                    .WithMany(p => p.CCOB_RCCL)
                    .HasForeignKey(d => d.RCCL_CLIENTE)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CLIE_R13");

                entity.HasOne(d => d.RCCL_COBRADORNavigation)
                    .WithMany(p => p.CCOB_RCCL)
                    .HasForeignKey(d => d.RCCL_COBRADOR)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COBR_R03");

                entity.HasOne(d => d.RCCL_CUENTA_DTOSNavigation)
                    .WithMany(p => p.CCOB_RCCL)
                    .HasForeignKey(d => d.RCCL_CUENTA_DTOS)
                    .HasConstraintName("CUEN_R129");

                entity.HasOne(d => d.RCCL_NC_DTOSNavigation)
                    .WithMany(p => p.CCOB_RCCLRCCL_NC_DTOSNavigation)
                    .HasForeignKey(d => d.RCCL_NC_DTOS)
                    .HasConstraintName("CTEC_R18");

                entity.HasOne(d => d.RCCL_ND_DTOSNavigation)
                    .WithMany(p => p.CCOB_RCCLRCCL_ND_DTOSNavigation)
                    .HasForeignKey(d => d.RCCL_ND_DTOS)
                    .HasConstraintName("CTEC_R19");

                entity.HasOne(d => d.RCCL_TIPO_FC_CDONavigation)
                    .WithMany(p => p.CCOB_RCCL)
                    .HasForeignKey(d => d.RCCL_TIPO_FC_CDO)
                    .HasConstraintName("TCBV_R20");

                entity.HasOne(d => d.RCCL_TIPO_RECNavigation)
                    .WithMany(p => p.CCOB_RCCL)
                    .HasForeignKey(d => d.RCCL_TIPO_REC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TCBR_R02");
            });

            modelBuilder.Entity<CCOB_TCBR>(entity =>
            {
                entity.HasKey(e => e.TCBR_TIPO_REC)
                    .HasName("TCBR_PK1")
                    .IsClustered(false);

                entity.Property(e => e.TCBR_TIPO_REC)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TCBR_AJU_DIF_REDRC).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBR_COMISIONABLE).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBR_CONTROL_NRCL).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBR_CTADEB_REDRC)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TCBR_CTAHAB_REDRC)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TCBR_DESCRIP_OBLIG).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBR_ES_ACRED_TARJ).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBR_FORMAT_REF)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TCBR_LIBRO_COMPRAS).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBR_LIBRO_VENTAS).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBR_REDMAX_REDRC).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TCBR_REF_OBLIG).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBR_REQ_SOLIC_COB).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBR_SUBDIARIO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TCBR_USA_TALONARIO).HasColumnType("decimal(1, 0)");

                entity.HasOne(d => d.TCBR_CTADEB_REDRCNavigation)
                    .WithMany(p => p.CCOB_TCBRTCBR_CTADEB_REDRCNavigation)
                    .HasForeignKey(d => d.TCBR_CTADEB_REDRC)
                    .HasConstraintName("CUEN_R105");

                entity.HasOne(d => d.TCBR_CTAHAB_REDRCNavigation)
                    .WithMany(p => p.CCOB_TCBRTCBR_CTAHAB_REDRCNavigation)
                    .HasForeignKey(d => d.TCBR_CTAHAB_REDRC)
                    .HasConstraintName("CUEN_R106");

                entity.HasOne(d => d.TCBR_TIPO_RECNavigation)
                    .WithOne(p => p.CCOB_TCBR)
                    .HasForeignKey<CCOB_TCBR>(d => d.TCBR_TIPO_REC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TCCB_R03");
            });

            modelBuilder.Entity<CCOB_TCBV>(entity =>
            {
                entity.HasKey(e => e.TCBV_TIPO_VAR)
                    .HasName("TCBV_PK1")
                    .IsClustered(false);

                entity.Property(e => e.TCBV_TIPO_VAR)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TCBV_ALM_ELEC_DUPL).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_CAMPO_OPCIONAL_FE).IsUnicode(false);

                entity.Property(e => e.TCBV_CLASIF_NPCV_1)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TCBV_CLASIF_NPCV_2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TCBV_CLASIF_NPCV_3)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TCBV_CLASIF_NPCV_4)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TCBV_CLASIF_NPCV_5)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TCBV_CLASIF_NPCV_6)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TCBV_COBRO_CORREL).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_COMISIONABLE).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_COMPENSABLE).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_CON_IMPUESTOS).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_ES_DIF_CAMBIO).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_ES_FCNDNC)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TCBV_ES_PTO_VENTA).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_ES_VENTA).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_LETRA)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TCBV_LIBRO_COMPRAS).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_LIBRO_VENTAS).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_RESVTA_RANGO).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCBV_SIGNO)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TCBV_SUBDIARIO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.TCBV_TIPO_VARNavigation)
                    .WithOne(p => p.CCOB_TCBV)
                    .HasForeignKey<CCOB_TCBV>(d => d.TCBV_TIPO_VAR)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TCCB_R02");
            });

            modelBuilder.Entity<CCOB_TCCB>(entity =>
            {
                entity.HasKey(e => e.TCCB_TIPO_COM)
                    .HasName("TCCB_PK1")
                    .IsClustered(false);

                entity.Property(e => e.TCCB_TIPO_COM)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TCCB_CLASE)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TCCB_CONTROL_SFEC).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TCCB_NOMBRE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TCCB_NOMBRE_IMP)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TCCB_UTILIZABLE).HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<CCOB_VCTC>(entity =>
            {
                entity.HasKey(e => new { e.VCTC_CTACTE_CTEC, e.VCTC_RENGLON_VCTC })
                    .HasName("VCTC_PK1")
                    .IsClustered(false);

                entity.Property(e => e.VCTC_FECHA_VTO).HasColumnType("datetime");

                entity.Property(e => e.VCTC_FECHA_VTO_FIN).HasColumnType("datetime");

                entity.Property(e => e.VCTC_FECHA_VTO_INT).HasColumnType("datetime");

                entity.Property(e => e.VCTC_IMP_LOC).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.VCTC_IMP_ORI).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.VCTC_SAL_LOC).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.VCTC_SAL_ORI).HasColumnType("decimal(14, 2)");

                entity.HasOne(d => d.VCTC_CTACTE_CTECNavigation)
                    .WithMany(p => p.CCOB_VCTC)
                    .HasForeignKey(d => d.VCTC_CTACTE_CTEC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CTEC_R06");
            });

            modelBuilder.Entity<CONT_CUEN>(entity =>
            {
                entity.HasKey(e => e.CUEN_CUENTA)
                    .HasName("CUEN_PK1")
                    .IsClustered(false);

                entity.Property(e => e.CUEN_CUENTA)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CUEN_AJU_CON).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_AJU_INF).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_CLASE_IMPUTABLE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CUEN_CUENTA_PADRE)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CUEN_DISTRIBUCION).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_ES_CARGO_DIF).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_ES_MONETARIA).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_ES_OP_ESPECIE).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_FECHA_TOPE_IMPUTACION).HasColumnType("datetime");

                entity.Property(e => e.CUEN_IMPUTABLE).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_ACTIVO).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_AUTO).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_CCOBRAR).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_COMPRAS).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_CONTAB).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_CPAGAR).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_GS_CONTR).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_PRODUC).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_STOCK).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_SUELDOS).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_TESOR).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_IMP_VENTAS).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_MAESTRO)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CUEN_MONEDA)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CUEN_NOMBRE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CUEN_SIGNO_SAL)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CUEN_UNIMED)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CUEN_USA_REFER).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.CUEN_UTILIZABLE).HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<DMCOBRADOR>(entity =>
            {
                entity.HasKey(e => e.COBR_ID)
                    .HasName("PK__DMCOBRAD__3569AB8F55F0AA63");

                entity.Property(e => e.COBR_COBRADOR)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DMCTA_CONT>(entity =>
            {
                entity.HasKey(e => e.CONT_ID)
                    .HasName("PK__DMCTA_CO__33DC4C797150142B");

                entity.Property(e => e.CONT_CTA)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DMED_TARJ>(entity =>
            {
                entity.HasKey(e => new { e.TARJ_TIPO_COMP, e.TARJ_TIPO_TARJETA })
                    .HasName("DMED_TARJ_P01")
                    .IsClustered(false);

                entity.Property(e => e.TARJ_TIPO_COMP)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TARJ_CUENTA)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.TARJ_CUENTANavigation)
                    .WithMany(p => p.DMED_TARJ)
                    .HasForeignKey(d => d.TARJ_CUENTA)
                    .HasConstraintName("DMED_TARJ_R02");

                entity.HasOne(d => d.TARJ_TIPO_COMPNavigation)
                    .WithMany(p => p.DMED_TARJ)
                    .HasForeignKey(d => d.TARJ_TIPO_COMP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DMED_TARJ_R01");
            });

            modelBuilder.Entity<DMPARM_CONF>(entity =>
            {
                entity.HasKey(e => e.PARM_ID)
                    .HasName("PK__DMPARM_C__EDA683DEB47D6162");

                entity.Property(e => e.PARM_NOMBRE).IsUnicode(false);
            });

            modelBuilder.Entity<DMTIPO_FACT>(entity =>
            {
                entity.HasKey(e => e.FACT_ID)
                    .HasName("PK__DMTIPO_F__856BE749FD7FF123");

                entity.Property(e => e.FACT_TIPO_FACT)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DMTIPO_RECI>(entity =>
            {
                entity.HasKey(e => e.RECI_ID)
                    .HasName("PK__DMTIPO_R__52D14E49D752E54E");

                entity.Property(e => e.RECI_TIPO_RECI)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SIST_COBR>(entity =>
            {
                entity.HasKey(e => e.COBR_COBRADOR)
                    .HasName("COBR_PK1")
                    .IsClustered(false);

                entity.Property(e => e.COBR_COBRADOR)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.COBR_NOMBRE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.COBR_PORC_COMISION).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.COBR_UTILIZABLE).HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<dmLOTE_COMPROBANTES>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LOTE_CLASIF_NPCV)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LOTE_COTIZACION).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LOTE_FECHA_EMI).HasColumnType("datetime");

                entity.Property(e => e.LOTE_IMPORTE_TOTAL).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LOTE_IMP_TOT_LOC).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LOTE_MAX_CVCL).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LOTE_MONEDA)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LOTE_NOMBRE_CLIENTE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LOTE_NRO_TARJ)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LOTE_NUMERO).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LOTE_NUMINT).ValueGeneratedOnAdd();

                entity.Property(e => e.LOTE_SALDO_LOC).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LOTE_SALDO_ORI).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LOTE_SIGNO)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LOTE_TIPO)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LOTE_TOTAL_SALDO_LOC).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LOTE_TOTAL_SALDO_ORI).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LOTE_VTO).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
