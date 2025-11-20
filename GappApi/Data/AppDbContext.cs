using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using GappApi.Models;

namespace GappApi.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdmAdapter> AdmAdapter { get; set; } = null!;
        public virtual DbSet<AdmAdapterAlias> AdmAdapterAlias { get; set; } = null!;
        public virtual DbSet<AdmBackupHistory> AdmBackupHistory { get; set; } = null!;
        public virtual DbSet<AdmBackupSetId> AdmBackupSetId { get; set; } = null!;
        public virtual DbSet<AdmBackupSettings> AdmBackupSettings { get; set; } = null!;
        public virtual DbSet<AdmGroup> AdmGroup { get; set; } = null!;
        public virtual DbSet<AdmGroupSetting> AdmGroupSetting { get; set; } = null!;
        public virtual DbSet<AdmHost> AdmHost { get; set; } = null!;
        public virtual DbSet<AdmHostInstance> AdmHostInstance { get; set; } = null!;
        public virtual DbSet<AdmHostInstanceSetting> AdmHostInstanceSetting { get; set; } = null!;
        public virtual DbSet<AdmHostInstanceSubServices> AdmHostInstanceSubServices { get; set; } = null!;
        public virtual DbSet<AdmHostInstanceZombie> AdmHostInstanceZombie { get; set; } = null!;
        public virtual DbSet<AdmHostSetting> AdmHostSetting { get; set; } = null!;
        public virtual DbSet<AdmMessageBox> AdmMessageBox { get; set; } = null!;
        public virtual DbSet<AdmOtherBackupDatabases> AdmOtherBackupDatabases { get; set; } = null!;
        public virtual DbSet<AdmOtherDatabases> AdmOtherDatabases { get; set; } = null!;
        public virtual DbSet<AdmReceiveHandler> AdmReceiveHandler { get; set; } = null!;
        public virtual DbSet<AdmReceiveLocation> AdmReceiveLocation { get; set; } = null!;
        public virtual DbSet<AdmSendHandler> AdmSendHandler { get; set; } = null!;
        public virtual DbSet<AdmServer> AdmServer { get; set; } = null!;
        public virtual DbSet<AdmServer2HostMapping> AdmServer2HostMapping { get; set; } = null!;
        public virtual DbSet<AdmServiceClass> AdmServiceClass { get; set; } = null!;
        public virtual DbSet<AdmvBackupDatabases> AdmvBackupDatabases { get; set; } = null!;
        public virtual DbSet<AdmvLocalDate> AdmvLocalDate { get; set; } = null!;
        public virtual DbSet<AdmvUtcdate> AdmvUtcdate { get; set; } = null!;
        public virtual DbSet<AdplSat> AdplSat { get; set; } = null!;
        public virtual DbSet<Agreement> Agreement { get; set; } = null!;
        public virtual DbSet<AgreementAlias> AgreementAlias { get; set; } = null!;
        public virtual DbSet<As2protocolSettings> As2protocolSettings { get; set; } = null!;
        public virtual DbSet<BamActivityToOrchestrationMapping> BamActivityToOrchestrationMapping { get; set; } = null!;
        public virtual DbSet<BamTrackPoints> BamTrackPoints { get; set; } = null!;
        public virtual DbSet<BamTrackingProfiles> BamTrackingProfiles { get; set; } = null!;
        public virtual DbSet<BasProperties> BasProperties { get; set; } = null!;
        public virtual DbSet<BatchDescription> BatchDescription { get; set; } = null!;
        public virtual DbSet<BizTalkCuversion> BizTalkCuversion { get; set; } = null!;
        public virtual DbSet<BizTalkDbversion> BizTalkDbversion { get; set; } = null!;
        public virtual DbSet<BtDocumentSpec> BtDocumentSpec { get; set; } = null!;
        public virtual DbSet<BtMapSpec> BtMapSpec { get; set; } = null!;
        public virtual DbSet<BtProperties> BtProperties { get; set; } = null!;
        public virtual DbSet<BtSensitiveProperties> BtSensitiveProperties { get; set; } = null!;
        public virtual DbSet<BtXmlshare> BtXmlshare { get; set; } = null!;
        public virtual DbSet<BtXmlshareReferences> BtXmlshareReferences { get; set; } = null!;
        public virtual DbSet<BtfMessageReceiver> BtfMessageReceiver { get; set; } = null!;
        public virtual DbSet<BtfMessageSender> BtfMessageSender { get; set; } = null!;
        public virtual DbSet<BtsApplication> BtsApplication { get; set; } = null!;
        public virtual DbSet<BtsApplicationReference> BtsApplicationReference { get; set; } = null!;
        public virtual DbSet<BtsAssembly> BtsAssembly { get; set; } = null!;
        public virtual DbSet<BtsComponent> BtsComponent { get; set; } = null!;
        public virtual DbSet<BtsDynamicSendportHandlers> BtsDynamicSendportHandlers { get; set; } = null!;
        public virtual DbSet<BtsDynamicportSubids> BtsDynamicportSubids { get; set; } = null!;
        public virtual DbSet<BtsEnlistedparty> BtsEnlistedparty { get; set; } = null!;
        public virtual DbSet<BtsEnlistedpartyOperationMapping> BtsEnlistedpartyOperationMapping { get; set; } = null!;
        public virtual DbSet<BtsEnlistedpartyPortMapping> BtsEnlistedpartyPortMapping { get; set; } = null!;
        public virtual DbSet<BtsItem> BtsItem { get; set; } = null!;
        public virtual DbSet<BtsItemreference> BtsItemreference { get; set; } = null!;
        public virtual DbSet<BtsLibreference> BtsLibreference { get; set; } = null!;
        public virtual DbSet<BtsMessagetype> BtsMessagetype { get; set; } = null!;
        public virtual DbSet<BtsMessagetypePart> BtsMessagetypePart { get; set; } = null!;
        public virtual DbSet<BtsOperationMsgtype> BtsOperationMsgtype { get; set; } = null!;
        public virtual DbSet<BtsOrchestration> BtsOrchestration { get; set; } = null!;
        public virtual DbSet<BtsOrchestrationInvocation> BtsOrchestrationInvocation { get; set; } = null!;
        public virtual DbSet<BtsOrchestrationPort> BtsOrchestrationPort { get; set; } = null!;
        public virtual DbSet<BtsOrchestrationPortBinding> BtsOrchestrationPortBinding { get; set; } = null!;
        public virtual DbSet<BtsParty> BtsParty { get; set; } = null!;
        public virtual DbSet<BtsPartyAlias> BtsPartyAlias { get; set; } = null!;
        public virtual DbSet<BtsPartyAliasOld> BtsPartyAliasOld { get; set; } = null!;
        public virtual DbSet<BtsPartyOld> BtsPartyOld { get; set; } = null!;
        public virtual DbSet<BtsPartySendport> BtsPartySendport { get; set; } = null!;
        public virtual DbSet<BtsPartySendportOld> BtsPartySendportOld { get; set; } = null!;
        public virtual DbSet<BtsPipeline> BtsPipeline { get; set; } = null!;
        public virtual DbSet<BtsPipelineConfig> BtsPipelineConfig { get; set; } = null!;
        public virtual DbSet<BtsPipelineStage> BtsPipelineStage { get; set; } = null!;
        public virtual DbSet<BtsPortActivationOperation> BtsPortActivationOperation { get; set; } = null!;
        public virtual DbSet<BtsPorttype> BtsPorttype { get; set; } = null!;
        public virtual DbSet<BtsPorttypeOperation> BtsPorttypeOperation { get; set; } = null!;
        public virtual DbSet<BtsReceiveport> BtsReceiveport { get; set; } = null!;
        public virtual DbSet<BtsReceiveportTransform> BtsReceiveportTransform { get; set; } = null!;
        public virtual DbSet<BtsRole> BtsRole { get; set; } = null!;
        public virtual DbSet<BtsRolePorttype> BtsRolePorttype { get; set; } = null!;
        public virtual DbSet<BtsRolelink> BtsRolelink { get; set; } = null!;
        public virtual DbSet<BtsRolelinkType> BtsRolelinkType { get; set; } = null!;
        public virtual DbSet<BtsSendport> BtsSendport { get; set; } = null!;
        public virtual DbSet<BtsSendportTransform> BtsSendportTransform { get; set; } = null!;
        public virtual DbSet<BtsSendportTransport> BtsSendportTransport { get; set; } = null!;
        public virtual DbSet<BtsSendportgroup> BtsSendportgroup { get; set; } = null!;
        public virtual DbSet<BtsSpgSendport> BtsSpgSendport { get; set; } = null!;
        public virtual DbSet<BtsStageConfig> BtsStageConfig { get; set; } = null!;
        public virtual DbSet<BtsmonInconsistancies> BtsmonInconsistancies { get; set; } = null!;
        public virtual DbSet<BtsmonIssues> BtsmonIssues { get; set; } = null!;
        public virtual DbSet<BtsvVersionIndependentOrchestration> BtsvVersionIndependentOrchestration { get; set; } = null!;
        public virtual DbSet<BusinessIdentity> BusinessIdentity { get; set; } = null!;
        public virtual DbSet<BusinessProfile> BusinessProfile { get; set; } = null!;
        public virtual DbSet<Contact> Contact { get; set; } = null!;
        public virtual DbSet<CustomSettings> CustomSettings { get; set; } = null!;
        public virtual DbSet<EdiDbConfig> EdiDbConfig { get; set; } = null!;
        public virtual DbSet<EdifactenvelopeOverrides> EdifactenvelopeOverrides { get; set; } = null!;
        public virtual DbSet<EdifactmessageFilterList> EdifactmessageFilterList { get; set; } = null!;
        public virtual DbSet<EdifactprotocolSettings> EdifactprotocolSettings { get; set; } = null!;
        public virtual DbSet<EdifactschemaOverrides> EdifactschemaOverrides { get; set; } = null!;
        public virtual DbSet<EdifactvalidationOverrides> EdifactvalidationOverrides { get; set; } = null!;
        public virtual DbSet<Edix12st01gs01mapping> Edix12st01gs01mapping { get; set; } = null!;
        public virtual DbSet<FallbackSettings> FallbackSettings { get; set; } = null!;
        public virtual DbSet<MarkLog> MarkLog { get; set; } = null!;
        public virtual DbSet<OnewayAgreement> OnewayAgreement { get; set; } = null!;
        public virtual DbSet<PamBatchingLog> PamBatchingLog { get; set; } = null!;
        public virtual DbSet<PamControl> PamControl { get; set; } = null!;
        public virtual DbSet<Partner> Partner { get; set; } = null!;
        public virtual DbSet<Partnership> Partnership { get; set; } = null!;
        public virtual DbSet<ProtocolSettings> ProtocolSettings { get; set; } = null!;
        public virtual DbSet<SendPortReference> SendPortReference { get; set; } = null!;
        public virtual DbSet<StaticTrackingInfo> StaticTrackingInfo { get; set; } = null!;
        public virtual DbSet<TddsCustomFormats> TddsCustomFormats { get; set; } = null!;
        public virtual DbSet<TddsDestinations> TddsDestinations { get; set; } = null!;
        public virtual DbSet<TddsHeartbeats> TddsHeartbeats { get; set; } = null!;
        public virtual DbSet<TddsServices> TddsServices { get; set; } = null!;
        public virtual DbSet<TddsSettings> TddsSettings { get; set; } = null!;
        public virtual DbSet<TddsSources> TddsSources { get; set; } = null!;
        public virtual DbSet<TestSettings> TestSettings { get; set; } = null!;
        public virtual DbSet<Trackinginterceptor> Trackinginterceptor { get; set; } = null!;
        public virtual DbSet<TrackinginterceptorVersions> TrackinginterceptorVersions { get; set; } = null!;
        public virtual DbSet<X12envelopesOverrides> X12envelopesOverrides { get; set; } = null!;
        public virtual DbSet<X12messageFilterList> X12messageFilterList { get; set; } = null!;
        public virtual DbSet<X12protocolSettings> X12protocolSettings { get; set; } = null!;
        public virtual DbSet<X12schemaOverrides> X12schemaOverrides { get; set; } = null!;
        public virtual DbSet<X12validationOverrides> X12validationOverrides { get; set; } = null!;
        public virtual DbSet<XrefAppInstance> XrefAppInstance { get; set; } = null!;
        public virtual DbSet<XrefAppType> XrefAppType { get; set; } = null!;
        public virtual DbSet<XrefIdxref> XrefIdxref { get; set; } = null!;
        public virtual DbSet<XrefIdxrefData> XrefIdxrefData { get; set; } = null!;
        public virtual DbSet<XrefMessageArgument> XrefMessageArgument { get; set; } = null!;
        public virtual DbSet<XrefMessageDef> XrefMessageDef { get; set; } = null!;
        public virtual DbSet<XrefMessageText> XrefMessageText { get; set; } = null!;
        public virtual DbSet<XrefValueXref> XrefValueXref { get; set; } = null!;
        public virtual DbSet<XrefValueXrefData> XrefValueXrefData { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdmAdapter>(entity =>
            {
                entity.ToTable("adm_Adapter");

                entity.HasIndex(e => e.Name, "adm_Adapter_unique_key1")
                    .IsUnique();

                entity.HasIndex(e => e.MgmtClsid, "adm_Adapter_unique_key2")
                    .IsUnique();

                entity.Property(e => e.Comment).HasMaxLength(256);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DefaultRhcfg)
                    .HasColumnType("ntext")
                    .HasColumnName("DefaultRHCfg");

                entity.Property(e => e.DefaultThcfg)
                    .HasColumnType("ntext")
                    .HasColumnName("DefaultTHCfg");

                entity.Property(e => e.InboundAssemblyPath).HasMaxLength(256);

                entity.Property(e => e.InboundEngineClsid).HasColumnName("InboundEngineCLSID");

                entity.Property(e => e.InboundTypeName).HasMaxLength(256);

                entity.Property(e => e.MgmtClsid).HasColumnName("MgmtCLSID");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.OutboundAssemblyPath).HasMaxLength(256);

                entity.Property(e => e.OutboundEngineClsid).HasColumnName("OutboundEngineCLSID");

                entity.Property(e => e.OutboundTypeName).HasMaxLength(256);

                entity.Property(e => e.PropertyNameSpace).HasMaxLength(256);
            });

            modelBuilder.Entity<AdmAdapterAlias>(entity =>
            {
                entity.ToTable("adm_AdapterAlias");

                entity.HasIndex(e => e.AliasValue, "adm_AdapterAlias_unique_key")
                    .IsUnique();

                entity.Property(e => e.AliasValue).HasMaxLength(64);
            });

            modelBuilder.Entity<AdmBackupHistory>(entity =>
            {
                entity.HasKey(e => e.BackupId)
                    .HasName("pk_adm_BackupHistory_BackupId");

                entity.ToTable("adm_BackupHistory");

                entity.HasIndex(e => new { e.BackupSetId, e.DatabaseName, e.ServerName }, "IX_BackupHistory")
                    .IsUnique();

                entity.Property(e => e.BackupDateTime).HasColumnType("datetime");

                entity.Property(e => e.BackupFileLocation).HasMaxLength(3000);

                entity.Property(e => e.BackupFileName).HasMaxLength(500);

                entity.Property(e => e.BackupType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DatabaseName).HasMaxLength(128);

                entity.Property(e => e.MarkName).HasMaxLength(32);

                entity.Property(e => e.ServerName).HasMaxLength(128);
            });

            modelBuilder.Entity<AdmBackupSetId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("adm_BackupSetId");
            });

            modelBuilder.Entity<AdmBackupSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("adm_BackupSettings");
            });

            modelBuilder.Entity<AdmGroup>(entity =>
            {
                entity.ToTable("adm_Group");

                entity.HasIndex(e => e.Name, "adm_Group_unique_key")
                    .IsUnique();

                entity.Property(e => e.BamDbname)
                    .HasMaxLength(128)
                    .HasColumnName("BamDBName");

                entity.Property(e => e.BamDbserverName)
                    .HasMaxLength(80)
                    .HasColumnName("BamDBServerName");

                entity.Property(e => e.BizTalkAdminGroup).HasMaxLength(128);

                entity.Property(e => e.BizTalkB2boperatorGroup)
                    .HasMaxLength(128)
                    .HasColumnName("BizTalkB2BOperatorGroup");

                entity.Property(e => e.BizTalkOperatorGroup).HasMaxLength(128);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LmsfragmentSize).HasColumnName("LMSFragmentSize");

                entity.Property(e => e.Lmsthreshold).HasColumnName("LMSThreshold");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.RuleEngineDbname)
                    .HasMaxLength(128)
                    .HasColumnName("RuleEngineDBName");

                entity.Property(e => e.RuleEngineDbserverName)
                    .HasMaxLength(80)
                    .HasColumnName("RuleEngineDBServerName");

                entity.Property(e => e.SignCertName).HasMaxLength(256);

                entity.Property(e => e.SignCertThumbprint).HasMaxLength(80);

                entity.Property(e => e.SsoserverName)
                    .HasMaxLength(80)
                    .HasColumnName("SSOServerName");

                entity.Property(e => e.SubscriptionDbname)
                    .HasMaxLength(128)
                    .HasColumnName("SubscriptionDBName");

                entity.Property(e => e.SubscriptionDbserverName)
                    .HasMaxLength(80)
                    .HasColumnName("SubscriptionDBServerName");

                entity.Property(e => e.TrackAnalysisDbname)
                    .HasMaxLength(128)
                    .HasColumnName("TrackAnalysisDBName");

                entity.Property(e => e.TrackAnalysisServerName).HasMaxLength(80);

                entity.Property(e => e.TrackingConfiguration).HasColumnType("image");

                entity.Property(e => e.TrackingDbname)
                    .HasMaxLength(128)
                    .HasColumnName("TrackingDBName");

                entity.Property(e => e.TrackingDbserverName)
                    .HasMaxLength(80)
                    .HasColumnName("TrackingDBServerName");

                entity.Property(e => e.Uuid).HasColumnName("UUID");

                entity.HasOne(d => d.DefaultHost)
                    .WithMany(p => p.AdmGroup)
                    .HasForeignKey(d => d.DefaultHostId)
                    .HasConstraintName("adm_Group_fk_DefaultHost");
            });

            modelBuilder.Entity<AdmGroupSetting>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.PropertyName })
                    .HasName("adm_GroupSetting_pk");

                entity.ToTable("adm_GroupSetting");

                entity.Property(e => e.PropertyName).HasMaxLength(100);

                entity.Property(e => e.PropertyValue).HasMaxLength(256);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AdmGroupSetting)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_GroupSetting_fk_group");
            });

            modelBuilder.Entity<AdmHost>(entity =>
            {
                entity.ToTable("adm_Host");

                entity.HasIndex(e => new { e.GroupId, e.Name }, "adm_Host_unique_key")
                    .IsUnique();

                entity.Property(e => e.ClusterResourceGroupName).HasMaxLength(256);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DbqueueSizeThreshold).HasColumnName("DBQueueSizeThreshold");

                entity.Property(e => e.DbsessionThreshold).HasColumnName("DBSessionThreshold");

                entity.Property(e => e.DecryptCertName).HasMaxLength(256);

                entity.Property(e => e.DecryptCertThumbprint).HasMaxLength(80);

                entity.Property(e => e.LastUsedLogon).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(80);

                entity.Property(e => e.NtgroupName)
                    .HasMaxLength(128)
                    .HasColumnName("NTGroupName");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AdmHost)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_Host_fk_group");
            });

            modelBuilder.Entity<AdmHostInstance>(entity =>
            {
                entity.ToTable("adm_HostInstance");

                entity.HasIndex(e => e.UniqueId, "adm_HostInstance_unique_id")
                    .IsUnique();

                entity.HasIndex(e => e.Svr2HostMappingId, "adm_HostInstance_unique_key")
                    .IsUnique();

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.InstallationContext).HasMaxLength(256);

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(256)
                    .HasColumnName("nvcDescription");

                entity.HasOne(d => d.Svr2HostMapping)
                    .WithOne(p => p.AdmHostInstance)
                    .HasForeignKey<AdmHostInstance>(d => d.Svr2HostMappingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_HostInstance_fk_srv2host");
            });

            modelBuilder.Entity<AdmHostInstanceSetting>(entity =>
            {
                entity.HasKey(e => new { e.HostInstanceId, e.PropertyName })
                    .HasName("adm_HostInstanceSetting_pk");

                entity.ToTable("adm_HostInstanceSetting");

                entity.Property(e => e.PropertyName).HasMaxLength(100);

                entity.Property(e => e.PropertyValue).HasMaxLength(256);

                entity.HasOne(d => d.HostInstance)
                    .WithMany(p => p.AdmHostInstanceSetting)
                    .HasForeignKey(d => d.HostInstanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_HostInstanceSetting_fk_hostInstance");
            });

            modelBuilder.Entity<AdmHostInstanceSubServices>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("adm_HostInstance_SubServices");

                entity.Property(e => e.ContextParam).HasMaxLength(256);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MonikerName).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<AdmHostInstanceZombie>(entity =>
            {
                entity.ToTable("adm_HostInstanceZombie");

                entity.HasIndex(e => e.UniqueId, "adm_HostInstanceZombie_unique_id")
                    .IsUnique();

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasMaxLength(256);

                entity.Property(e => e.HostName).HasMaxLength(80);

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NtgroupName)
                    .HasMaxLength(128)
                    .HasColumnName("NTGroupName");

                entity.Property(e => e.ServerName).HasMaxLength(63);
            });

            modelBuilder.Entity<AdmHostSetting>(entity =>
            {
                entity.HasKey(e => new { e.HostId, e.PropertyName })
                    .HasName("adm_HostSetting_pk");

                entity.ToTable("adm_HostSetting");

                entity.Property(e => e.PropertyName).HasMaxLength(100);

                entity.Property(e => e.PropertyValue).HasMaxLength(256);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.AdmHostSetting)
                    .HasForeignKey(d => d.HostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_HostSetting_fk_host");
            });

            modelBuilder.Entity<AdmMessageBox>(entity =>
            {
                entity.ToTable("adm_MessageBox");

                entity.HasIndex(e => new { e.DbserverName, e.Dbname }, "adm_MessageBox_unique_key")
                    .IsUnique();

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Dbname)
                    .HasMaxLength(128)
                    .HasColumnName("DBName");

                entity.Property(e => e.DbserverName)
                    .HasMaxLength(80)
                    .HasColumnName("DBServerName");

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(256)
                    .HasColumnName("nvcDescription");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AdmMessageBox)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_MessageBox_fk_group");
            });

            modelBuilder.Entity<AdmOtherBackupDatabases>(entity =>
            {
                entity.HasKey(e => new { e.DefaultDatabaseName, e.BtsserverName })
                    .HasName("adm_OtherBackupDatabases_PK");

                entity.ToTable("adm_OtherBackupDatabases");

                entity.Property(e => e.DefaultDatabaseName).HasMaxLength(128);

                entity.Property(e => e.BtsserverName)
                    .HasMaxLength(80)
                    .HasColumnName("BTSServerName");

                entity.Property(e => e.DatabaseName).HasMaxLength(128);

                entity.Property(e => e.ServerName).HasMaxLength(80);
            });

            modelBuilder.Entity<AdmOtherDatabases>(entity =>
            {
                entity.HasKey(e => new { e.DefaultDatabaseName, e.BtsserverName })
                    .HasName("adm_OtherDatabases_PK");

                entity.ToTable("adm_OtherDatabases");

                entity.Property(e => e.DefaultDatabaseName).HasMaxLength(128);

                entity.Property(e => e.BtsserverName)
                    .HasMaxLength(80)
                    .HasColumnName("BTSServerName");

                entity.Property(e => e.DatabaseName).HasMaxLength(128);

                entity.Property(e => e.ServerName).HasMaxLength(80);
            });

            modelBuilder.Entity<AdmReceiveHandler>(entity =>
            {
                entity.ToTable("adm_ReceiveHandler");

                entity.HasIndex(e => new { e.HostId, e.AdapterId }, "adm_ReceiveHandler_unique_key")
                    .IsUnique();

                entity.Property(e => e.CustomCfg).HasColumnType("ntext");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(256)
                    .HasColumnName("nvcDescription");

                entity.Property(e => e.UidCustomCfgId).HasColumnName("uidCustomCfgID");

                entity.Property(e => e.UidReceiveLocationSsoappId).HasColumnName("uidReceiveLocationSSOAppID");

                entity.HasOne(d => d.Adapter)
                    .WithMany(p => p.AdmReceiveHandler)
                    .HasForeignKey(d => d.AdapterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_ReceiveHandler_fk_adapter");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AdmReceiveHandler)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_ReceiveHandler_fk_group");

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.AdmReceiveHandler)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("adm_ReceiveHandler_fk_host");
            });

            modelBuilder.Entity<AdmReceiveLocation>(entity =>
            {
                entity.ToTable("adm_ReceiveLocation");

                entity.HasIndex(e => e.ReceiveHandlerId, "adm_ReceiveLocation_ix_RH");

                entity.HasIndex(e => e.InboundTransportUrl, "adm_ReceiveLocation_unique_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.Name, e.GroupId }, "adm_ReceiveLocation_unique_key1")
                    .IsUnique();

                entity.Property(e => e.ActiveStartDt)
                    .HasColumnType("datetime")
                    .HasColumnName("ActiveStartDT");

                entity.Property(e => e.ActiveStopDt)
                    .HasColumnType("datetime")
                    .HasColumnName("ActiveStopDT");

                entity.Property(e => e.BSsomappingExists).HasColumnName("bSSOMappingExists");

                entity.Property(e => e.Comment).HasMaxLength(256);

                entity.Property(e => e.CustomCfg).HasColumnType("ntext");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.EncryptionCert).HasMaxLength(256);

                entity.Property(e => e.EncryptionCertThumbPrint).HasMaxLength(80);

                entity.Property(e => e.InboundAddressableUrl)
                    .HasMaxLength(256)
                    .HasColumnName("InboundAddressableURL");

                entity.Property(e => e.InboundTransportUrl)
                    .HasMaxLength(256)
                    .HasColumnName("InboundTransportURL");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NvcCustomData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcCustomData");

                entity.Property(e => e.ReceivePipelineData).HasColumnType("ntext");

                entity.Property(e => e.SendPipelineData).HasColumnType("ntext");

                entity.Property(e => e.SrvWinStartDt)
                    .HasColumnType("datetime")
                    .HasColumnName("SrvWinStartDT");

                entity.Property(e => e.SrvWinStopDt)
                    .HasColumnType("datetime")
                    .HasColumnName("SrvWinStopDT");

                entity.Property(e => e.StartDtenabled).HasColumnName("StartDTEnabled");

                entity.Property(e => e.StopDtenabled).HasColumnName("StopDTEnabled");

                entity.Property(e => e.UidCustomCfgId).HasColumnName("uidCustomCfgID");

                entity.HasOne(d => d.Adapter)
                    .WithMany(p => p.AdmReceiveLocation)
                    .HasForeignKey(d => d.AdapterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_ReceiveLocation_fk_adapter");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AdmReceiveLocation)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("adm_ReceiveLocation_fk_group");

                entity.HasOne(d => d.ReceiveHandler)
                    .WithMany(p => p.AdmReceiveLocation)
                    .HasForeignKey(d => d.ReceiveHandlerId)
                    .HasConstraintName("adm_ReceiveLocation_fk_RH");

                entity.HasOne(d => d.ReceivePipeline)
                    .WithMany(p => p.AdmReceiveLocationReceivePipeline)
                    .HasForeignKey(d => d.ReceivePipelineId)
                    .HasConstraintName("adm_ReceiveLocation_fk_Pipeline");

                entity.HasOne(d => d.ReceivePort)
                    .WithMany(p => p.AdmReceiveLocation)
                    .HasForeignKey(d => d.ReceivePortId)
                    .HasConstraintName("adm_ReceiveLocation_fk_ReceivePort");

                entity.HasOne(d => d.SendPipeline)
                    .WithMany(p => p.AdmReceiveLocationSendPipeline)
                    .HasForeignKey(d => d.SendPipelineId)
                    .HasConstraintName("adm_ReceiveLocation_fk_SendPipeline");
            });

            modelBuilder.Entity<AdmSendHandler>(entity =>
            {
                entity.ToTable("adm_SendHandler");

                entity.HasIndex(e => new { e.HostId, e.AdapterId }, "adm_SendHandler_unique_key")
                    .IsUnique();

                entity.Property(e => e.CustomCfg).HasColumnType("ntext");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(256)
                    .HasColumnName("nvcDescription");

                entity.Property(e => e.UidCustomCfgId).HasColumnName("uidCustomCfgID");

                entity.Property(e => e.UidTransmitLocationSsoappId).HasColumnName("uidTransmitLocationSSOAppId");

                entity.HasOne(d => d.Adapter)
                    .WithMany(p => p.AdmSendHandler)
                    .HasForeignKey(d => d.AdapterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_SendHandler_fk_adapter");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AdmSendHandler)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_SendHandler_fk_group");

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.AdmSendHandler)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("adm_SendHandler_fk_host");
            });

            modelBuilder.Entity<AdmServer>(entity =>
            {
                entity.ToTable("adm_Server");

                entity.HasIndex(e => e.Name, "adm_Server_unique_key")
                    .IsUnique();

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(63);
            });

            modelBuilder.Entity<AdmServer2HostMapping>(entity =>
            {
                entity.ToTable("adm_Server2HostMapping");

                entity.HasIndex(e => new { e.ServerId, e.HostId }, "adm_Server2HostMapping_unique_key")
                    .IsUnique();

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.AdmServer2HostMapping)
                    .HasForeignKey(d => d.HostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_Server2HostMapping_fk_host");

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.AdmServer2HostMapping)
                    .HasForeignKey(d => d.ServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_Server2HostMapping_fk_server");
            });

            modelBuilder.Entity<AdmServiceClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("adm_ServiceClass");

                entity.HasIndex(e => e.Name, "adm_ServiceClass_unique_key")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<AdmvBackupDatabases>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("admv_BackupDatabases");

                entity.Property(e => e.DatabaseName).HasMaxLength(128);

                entity.Property(e => e.ServerName).HasMaxLength(128);
            });

            modelBuilder.Entity<AdmvLocalDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("admv_LocalDate");

                entity.Property(e => e.LocalDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdmvUtcdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("admv_UTCDate");

                entity.Property(e => e.Utcdate)
                    .HasColumnType("datetime")
                    .HasColumnName("UTCDate");
            });

            modelBuilder.Entity<AdplSat>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("adpl_sat");

                entity.HasIndex(e => e.ApplicationId, "IX_adpl_sat");

                entity.HasIndex(e => e.Luid, "UQ_adpl_sat")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationId");

                entity.Property(e => e.CabContent)
                    .HasColumnType("image")
                    .HasColumnName("cabContent");

                entity.Property(e => e.Files)
                    .HasColumnType("ntext")
                    .HasColumnName("files");

                entity.Property(e => e.Luid)
                    .HasMaxLength(440)
                    .HasColumnName("luid");

                entity.Property(e => e.Properties)
                    .HasColumnType("ntext")
                    .HasColumnName("properties");

                entity.Property(e => e.SdmType)
                    .HasMaxLength(256)
                    .HasColumnName("sdmType");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AdplSat)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bts_application_adpl_sat");
            });

            modelBuilder.Entity<Agreement>(entity =>
            {
                entity.ToTable("Agreement", "tpm");

                entity.HasIndex(e => new { e.PartnershipId, e.Name }, "UK_AgreementName")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Protocol).HasMaxLength(256);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Partnership)
                    .WithMany(p => p.Agreement)
                    .HasForeignKey(d => d.PartnershipId)
                    .HasConstraintName("FK_Agreement_Partnership");

                entity.HasOne(d => d.ReceiverProtocolSettings)
                    .WithMany(p => p.AgreementReceiverProtocolSettings)
                    .HasForeignKey(d => d.ReceiverProtocolSettingsId)
                    .HasConstraintName("FK_Agreement_ReceiverProtocolSettings");

                entity.HasOne(d => d.SenderProtocolSettings)
                    .WithMany(p => p.AgreementSenderProtocolSettings)
                    .HasForeignKey(d => d.SenderProtocolSettingsId)
                    .HasConstraintName("FK_Agreement_SenderProtocolSettings");
            });

            modelBuilder.Entity<AgreementAlias>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_OnewayAgreementAlias")
                    .IsClustered(false);

                entity.ToTable("AgreementAlias", "tpm");

                entity.HasIndex(e => e.OnewayAgreementId, "IX_AgreementAlias_OnewayAgreementId")
                    .IsClustered();

                entity.HasIndex(e => new { e.Key, e.Value, e.Protocol }, "UK_AgreementAlias")
                    .IsUnique();

                entity.Property(e => e.Key).HasMaxLength(64);

                entity.Property(e => e.Protocol).HasMaxLength(64);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.OnewayAgreement)
                    .WithMany(p => p.AgreementAlias)
                    .HasForeignKey(d => d.OnewayAgreementId)
                    .HasConstraintName("FK_AgreementAlias_OnewayAgreement");
            });

            modelBuilder.Entity<As2protocolSettings>(entity =>
            {
                entity.HasKey(e => e.SettingsId);

                entity.ToTable("AS2ProtocolSettings", "tpm");

                entity.Property(e => e.SettingsId).ValueGeneratedNever();

                entity.Property(e => e.CertificateThumbprint).HasMaxLength(256);

                entity.Property(e => e.DispositionNotificationTo).HasMaxLength(256);

                entity.Property(e => e.EnableNrrforInboundDecodedMessages).HasColumnName("EnableNRRForInboundDecodedMessages");

                entity.Property(e => e.EnableNrrforInboundEncodedMessages).HasColumnName("EnableNRRForInboundEncodedMessages");

                entity.Property(e => e.EnableNrrforInboundMdn).HasColumnName("EnableNRRForInboundMDN");

                entity.Property(e => e.EnableNrrforOutboundDecodedMessages).HasColumnName("EnableNRRForOutboundDecodedMessages");

                entity.Property(e => e.EnableNrrforOutboundEncodedMessages).HasColumnName("EnableNRRForOutboundEncodedMessages");

                entity.Property(e => e.EnableNrrforOutboundMdn).HasColumnName("EnableNRRForOutboundMDN");

                entity.Property(e => e.FileNameTemplate).HasMaxLength(2048);

                entity.Property(e => e.Mdntext)
                    .HasMaxLength(1024)
                    .HasColumnName("MDNText");

                entity.Property(e => e.MessageContentType).HasMaxLength(256);

                entity.Property(e => e.ProcessMdntoMsgBox).HasColumnName("ProcessMDNtoMsgBox");

                entity.Property(e => e.ReceiptDeliveryUrl).HasMaxLength(256);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithOne(p => p.As2protocolSettings)
                    .HasForeignKey<As2protocolSettings>(d => d.SettingsId)
                    .HasConstraintName("FK_AS2ProtocolSettings_ProtocolSettings");
            });

            modelBuilder.Entity<BamActivityToOrchestrationMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bam_ActivityToOrchestrationMapping");

                entity.Property(e => e.ActivityName)
                    .HasMaxLength(128)
                    .HasColumnName("activityName");

                entity.Property(e => e.ServiceId).HasColumnName("serviceId");
            });

            modelBuilder.Entity<BamTrackPoints>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bam_TrackPoints");

                entity.Property(e => e.NDirection).HasColumnName("nDirection");

                entity.Property(e => e.NProfileId).HasColumnName("nProfileId");

                entity.Property(e => e.NTrackPointId).HasColumnName("nTrackPointId");

                entity.Property(e => e.NtxtData)
                    .HasColumnType("ntext")
                    .HasColumnName("ntxtData");

                entity.Property(e => e.NvcMsgType)
                    .HasMaxLength(2048)
                    .HasColumnName("nvcMsgType");

                entity.Property(e => e.UidPortId).HasColumnName("uidPortId");
            });

            modelBuilder.Entity<BamTrackingProfiles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bam_TrackingProfiles");

                entity.Property(e => e.NId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("nID");

                entity.Property(e => e.NMinorVersionId).HasColumnName("nMinorVersionId");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(128)
                    .HasColumnName("nvcName");

                entity.Property(e => e.UidVersionId).HasColumnName("uidVersionId");
            });

            modelBuilder.Entity<BasProperties>(entity =>
            {
                entity.HasKey(e => e.PropertyName);

                entity.ToTable("bas_Properties");

                entity.Property(e => e.PropertyName).HasMaxLength(80);

                entity.Property(e => e.PropertyValue).HasMaxLength(260);
            });

            modelBuilder.Entity<BatchDescription>(entity =>
            {
                entity.ToTable("BatchDescription", "tpm");

                entity.HasIndex(e => new { e.OnewayAgreementId, e.Name }, "UK_BatchDescriptionName")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.FilterBytes).HasMaxLength(4000);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Protocol).HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.OnewayAgreement)
                    .WithMany(p => p.BatchDescription)
                    .HasForeignKey(d => d.OnewayAgreementId)
                    .HasConstraintName("FK_BatchDescription_OnewayAgreement");
            });

            modelBuilder.Entity<BizTalkCuversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BizTalkCUVersion");

                entity.Property(e => e.Cu).HasColumnName("CU");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<BizTalkDbversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BizTalkDBVersion");

                entity.HasIndex(e => new { e.BizTalkDbname, e.ProductMajor, e.ProductMinor, e.ProductBuildNumber, e.ProductRevision }, "BizTalkDBVersion_unique_key")
                    .IsUnique();

                entity.Property(e => e.BizTalkDbname)
                    .HasMaxLength(64)
                    .HasColumnName("BizTalkDBName");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductLanguage).HasMaxLength(256);
            });

            modelBuilder.Entity<BtDocumentSpec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bt_DocumentSpec");

                entity.HasIndex(e => e.Id, "IX_bt_DocumentSpec");

                entity.HasIndex(e => e.ClrNamespace, "IX_bt_DocumentSpec_clr_namespace")
                    .IsClustered();

                entity.HasIndex(e => new { e.Msgtype, e.Assemblyid, e.Shareid }, "IX_bt_DocumentSpec_msgtype");

                entity.HasIndex(e => e.Shareid, "IX_bt_DocumentSpec_shareid");

                entity.Property(e => e.Assemblyid).HasColumnName("assemblyid");

                entity.Property(e => e.BodyXpath)
                    .HasMaxLength(2421)
                    .HasColumnName("body_xpath");

                entity.Property(e => e.ClrAssemblyname)
                    .HasMaxLength(512)
                    .HasColumnName("clr_assemblyname");

                entity.Property(e => e.ClrNamespace)
                    .HasMaxLength(256)
                    .HasColumnName("clr_namespace");

                entity.Property(e => e.ClrTypename)
                    .HasMaxLength(256)
                    .HasColumnName("clr_typename");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("date_modified");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.DocspecName)
                    .HasMaxLength(513)
                    .HasColumnName("docspec_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsFlat).HasColumnName("is_flat");

                entity.Property(e => e.IsMultiroot).HasColumnName("is_multiroot");

                entity.Property(e => e.IsPropertySchema).HasColumnName("is_property_schema");

                entity.Property(e => e.IsTracked).HasColumnName("is_tracked");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Msgtype)
                    .HasMaxLength(2048)
                    .HasColumnName("msgtype");

                entity.Property(e => e.PropertyClrClass)
                    .HasMaxLength(2000)
                    .HasColumnName("property_clr_class");

                entity.Property(e => e.PropertyClrClassFqn)
                    .HasMaxLength(2770)
                    .HasColumnName("property_clr_class_fqn");

                entity.Property(e => e.SchemaRootClrFqn)
                    .HasMaxLength(513)
                    .HasColumnName("schema_root_clr_fqn");

                entity.Property(e => e.SchemaRootName)
                    .HasMaxLength(2000)
                    .HasColumnName("schema_root_name");

                entity.Property(e => e.Shareid).HasColumnName("shareid");

                entity.Property(e => e.XsdType)
                    .HasMaxLength(30)
                    .HasColumnName("xsd_type");

                entity.HasOne(d => d.Assembly)
                    .WithMany()
                    .HasForeignKey(d => d.Assemblyid)
                    .HasConstraintName("FK_bt_DocumentSpec_bts_assembly");

                entity.HasOne(d => d.Item)
                    .WithMany()
                    .HasForeignKey(d => d.Itemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bt_documentspec_bts_item");

                entity.HasOne(d => d.Share)
                    .WithMany()
                    .HasForeignKey(d => d.Shareid)
                    .HasConstraintName("fk_bt_documentspec_bt_xmlshare");
            });

            modelBuilder.Entity<BtMapSpec>(entity =>
            {
                entity.ToTable("bt_MapSpec");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Assemblyid).HasColumnName("assemblyid");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("date_modified");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.IndocDocspecName)
                    .HasMaxLength(256)
                    .HasColumnName("indoc_docspec_name");

                entity.Property(e => e.IndocNamespace)
                    .HasMaxLength(256)
                    .HasColumnName("indoc_namespace");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.OutdocDocspecName)
                    .HasMaxLength(256)
                    .HasColumnName("outdoc_docspec_name");

                entity.Property(e => e.OutdocNamespace)
                    .HasMaxLength(256)
                    .HasColumnName("outdoc_namespace");

                entity.Property(e => e.Shareid).HasColumnName("shareid");

                entity.HasOne(d => d.Assembly)
                    .WithMany(p => p.BtMapSpec)
                    .HasForeignKey(d => d.Assemblyid)
                    .HasConstraintName("FK_bt_MapSpec_bts_assembly");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.BtMapSpec)
                    .HasForeignKey(d => d.Itemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bt_mapspec_bts_item");

                entity.HasOne(d => d.Share)
                    .WithMany(p => p.BtMapSpec)
                    .HasForeignKey(d => d.Shareid)
                    .HasConstraintName("fk_bt_mapspec_bt_xmlshare");
            });

            modelBuilder.Entity<BtProperties>(entity =>
            {
                entity.ToTable("bt_Properties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IsTracked).HasColumnName("is_tracked");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Msgtype)
                    .HasMaxLength(2048)
                    .HasColumnName("msgtype");

                entity.Property(e => e.NAssemblyId).HasColumnName("nAssemblyID");

                entity.Property(e => e.Name)
                    .HasMaxLength(2048)
                    .HasColumnName("name");

                entity.Property(e => e.Namespace)
                    .HasMaxLength(256)
                    .HasColumnName("namespace");

                entity.Property(e => e.PropSchemaId).HasColumnName("propSchemaID");

                entity.Property(e => e.Xpath)
                    .HasMaxLength(3357)
                    .HasColumnName("xpath");

                entity.HasOne(d => d.NAssembly)
                    .WithMany(p => p.BtProperties)
                    .HasForeignKey(d => d.NAssemblyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_bt_Properties_bts_assembly");
            });

            modelBuilder.Entity<BtSensitiveProperties>(entity =>
            {
                entity.ToTable("bt_SensitiveProperties");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Assemblyid).HasColumnName("assemblyid");

                entity.Property(e => e.Msgtype)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("msgtype")
                    .IsFixedLength();

                entity.HasOne(d => d.Assembly)
                    .WithMany(p => p.BtSensitiveProperties)
                    .HasForeignKey(d => d.Assemblyid)
                    .HasConstraintName("FK_bt_SensitiveProperties_bts_assembly");
            });

            modelBuilder.Entity<BtXmlshare>(entity =>
            {
                entity.ToTable("bt_XMLShare");

                entity.HasIndex(e => new { e.Id, e.Active }, "IX_bt_XMLShare");

                entity.HasIndex(e => new { e.TargetNamespace, e.Active }, "IX_bt_XMLShare_target_namespace");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Content)
                    .HasColumnType("ntext")
                    .HasColumnName("content");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("date_modified");

                entity.Property(e => e.TargetNamespace)
                    .HasMaxLength(256)
                    .HasColumnName("target_namespace");
            });

            modelBuilder.Entity<BtXmlshareReferences>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bt_XMLShareReferences");

                entity.HasIndex(e => e.Shareid, "IX_bt_XMLShareReferences")
                    .IsClustered();

                entity.Property(e => e.Shareid).HasColumnName("shareid");

                entity.Property(e => e.TargetNamespace)
                    .HasMaxLength(256)
                    .HasColumnName("target_namespace");

                entity.HasOne(d => d.Share)
                    .WithMany()
                    .HasForeignKey(d => d.Shareid)
                    .HasConstraintName("FK_bt_XMLShareReferences_bt_XMLShare");
            });

            modelBuilder.Entity<BtfMessageReceiver>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("btf_message_receiver");

                entity.HasComment("BizTalk framework pipeline component message tracking table for receiver");

                entity.HasIndex(e => e.Identity, "CIX_BTF_Receiver")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ExpiresAt)
                    .HasColumnType("datetime")
                    .HasColumnName("expires_at");

                entity.Property(e => e.Identity)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("identity");
            });

            modelBuilder.Entity<BtfMessageSender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("btf_message_sender");

                entity.HasIndex(e => e.Identity, "CIX_BTF_Sender")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Acknowledged)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("acknowledged")
                    .IsFixedLength();

                entity.Property(e => e.ExpiresAt)
                    .HasColumnType("datetime")
                    .HasColumnName("expires_at");

                entity.Property(e => e.Identity)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("identity");
            });

            modelBuilder.Entity<BtsApplication>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_application_unique_key");

                entity.ToTable("bts_application");

                entity.HasIndex(e => e.NvcName, "bts_application_unique_name")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.IsSystem).HasColumnName("isSystem");

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(1024)
                    .HasColumnName("nvcDescription");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");
            });

            modelBuilder.Entity<BtsApplicationReference>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_applicationreference_unique_key");

                entity.ToTable("bts_application_reference");

                entity.HasIndex(e => new { e.NApplicationId, e.NReferencedApplicationId }, "bts_application_reference_unique")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NApplicationId).HasColumnName("nApplicationID");

                entity.Property(e => e.NReferencedApplicationId).HasColumnName("nReferencedApplicationID");

                entity.HasOne(d => d.NApplication)
                    .WithMany(p => p.BtsApplicationReferenceNApplication)
                    .HasForeignKey(d => d.NApplicationId)
                    .HasConstraintName("bts_application_foreign_applicationid");

                entity.HasOne(d => d.NReferencedApplication)
                    .WithMany(p => p.BtsApplicationReferenceNReferencedApplication)
                    .HasForeignKey(d => d.NReferencedApplicationId)
                    .HasConstraintName("bts_refapplication_foreign_applicationid");
            });

            modelBuilder.Entity<BtsAssembly>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_assembly");

                entity.HasIndex(e => new { e.NvcName, e.NVersionMajor, e.NVersionMinor, e.NVersionBuild, e.NVersionRevision, e.NId }, "IX_bts_assembly");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DtDateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDateModified");

                entity.Property(e => e.ImgTrackingProfile)
                    .HasColumnType("image")
                    .HasColumnName("imgTrackingProfile");

                entity.Property(e => e.NApplicationId).HasColumnName("nApplicationID");

                entity.Property(e => e.NGroupId).HasColumnName("nGroupId");

                entity.Property(e => e.NStrongName).HasColumnName("nStrongName");

                entity.Property(e => e.NSystemAssembly).HasColumnName("nSystemAssembly");

                entity.Property(e => e.NType).HasColumnName("nType");

                entity.Property(e => e.NVersionBuild).HasColumnName("nVersionBuild");

                entity.Property(e => e.NVersionMajor).HasColumnName("nVersionMajor");

                entity.Property(e => e.NVersionMinor).HasColumnName("nVersionMinor");

                entity.Property(e => e.NVersionRevision).HasColumnName("nVersionRevision");

                entity.Property(e => e.NtxtModuleXml)
                    .HasColumnType("ntext")
                    .HasColumnName("ntxtModuleXML");

                entity.Property(e => e.NvcCulture)
                    .HasMaxLength(256)
                    .HasColumnName("nvcCulture");

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(256)
                    .HasColumnName("nvcDescription");

                entity.Property(e => e.NvcFullName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcFullName");

                entity.Property(e => e.NvcIdentity)
                    .HasMaxLength(256)
                    .HasColumnName("nvcIdentity");

                entity.Property(e => e.NvcModifiedBy)
                    .HasMaxLength(64)
                    .HasColumnName("nvcModifiedBy");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcPublicKeyToken)
                    .HasMaxLength(256)
                    .HasColumnName("nvcPublicKeyToken");

                entity.Property(e => e.NvcType)
                    .HasMaxLength(256)
                    .HasColumnName("nvcType");

                entity.Property(e => e.NvcVersion)
                    .HasMaxLength(256)
                    .HasColumnName("nvcVersion");

                entity.HasOne(d => d.NApplication)
                    .WithMany(p => p.BtsAssembly)
                    .HasForeignKey(d => d.NApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_assembly_foreign_applicationid");
            });

            modelBuilder.Entity<BtsComponent>(entity =>
            {
                entity.ToTable("bts_component");

                entity.Property(e => e.AssemblyPath).HasMaxLength(256);

                entity.Property(e => e.ClsId).HasColumnName("ClsID");

                entity.Property(e => e.CustomData).HasColumnType("image");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.Property(e => e.TypeName).HasMaxLength(256);

                entity.Property(e => e.Version).HasMaxLength(10);
            });

            modelBuilder.Entity<BtsDynamicSendportHandlers>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("PK__bts_dyna__DF98CDFD30814E29");

                entity.ToTable("bts_dynamic_sendport_handlers");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.UidSendPortId).HasColumnName("uidSendPortID");

                entity.HasOne(d => d.SendHandler)
                    .WithMany(p => p.BtsDynamicSendportHandlers)
                    .HasForeignKey(d => d.SendHandlerId)
                    .HasConstraintName("bts_dynamic_sendport_handlers_foreign_sendhandlerid");
            });

            modelBuilder.Entity<BtsDynamicportSubids>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bts_dynamicport_subids");

                entity.Property(e => e.NSendHandlerId).HasColumnName("nSendHandlerID");

                entity.Property(e => e.NvcHostName)
                    .HasMaxLength(80)
                    .HasColumnName("nvcHostName");

                entity.Property(e => e.UidGuid).HasColumnName("uidGUID");

                entity.Property(e => e.UidSendPortId).HasColumnName("uidSendPortID");
            });

            modelBuilder.Entity<BtsEnlistedparty>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_enlistedparty_unique_key");

                entity.ToTable("bts_enlistedparty");

                entity.HasIndex(e => new { e.NRoleId, e.NPartyId }, "bts_enlistedparty_role_unique_key")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NPartyId).HasColumnName("nPartyID");

                entity.Property(e => e.NRoleId).HasColumnName("nRoleID");

                entity.HasOne(d => d.NParty)
                    .WithMany(p => p.BtsEnlistedparty)
                    .HasForeignKey(d => d.NPartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_enlistedparty_foreign_partyid");

                entity.HasOne(d => d.NRole)
                    .WithMany(p => p.BtsEnlistedparty)
                    .HasForeignKey(d => d.NRoleId)
                    .HasConstraintName("bts_enlistedparty_foreign_roleid");
            });

            modelBuilder.Entity<BtsEnlistedpartyOperationMapping>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_enlistedparty_operation_mapping_unique_key");

                entity.ToTable("bts_enlistedparty_operation_mapping");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NOperationId).HasColumnName("nOperationID");

                entity.Property(e => e.NPartySendPortId).HasColumnName("nPartySendPortID");

                entity.Property(e => e.NPortMappingId).HasColumnName("nPortMappingID");

                entity.HasOne(d => d.NOperation)
                    .WithMany(p => p.BtsEnlistedpartyOperationMapping)
                    .HasForeignKey(d => d.NOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_enlistedparty_operation_mapping_foreign_operationid");

                entity.HasOne(d => d.NPartySendPort)
                    .WithMany(p => p.BtsEnlistedpartyOperationMapping)
                    .HasForeignKey(d => d.NPartySendPortId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_enlistedparty_mapping_foreign_party_sendportid");

                entity.HasOne(d => d.NPortMapping)
                    .WithMany(p => p.BtsEnlistedpartyOperationMapping)
                    .HasForeignKey(d => d.NPortMappingId)
                    .HasConstraintName("bts_enlistedparty_mapping_foreign_portmappingid");
            });

            modelBuilder.Entity<BtsEnlistedpartyPortMapping>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_enlistedparty_port_mapping_unique_key");

                entity.ToTable("bts_enlistedparty_port_mapping");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NEnlistedPartyId).HasColumnName("nEnlistedPartyID");

                entity.Property(e => e.NRolePortTypeId).HasColumnName("nRolePortTypeID");

                entity.HasOne(d => d.NEnlistedParty)
                    .WithMany(p => p.BtsEnlistedpartyPortMapping)
                    .HasForeignKey(d => d.NEnlistedPartyId)
                    .HasConstraintName("bts_enlistedparty_portmapping_foreign_ownerid");

                entity.HasOne(d => d.NRolePortType)
                    .WithMany(p => p.BtsEnlistedpartyPortMapping)
                    .HasForeignKey(d => d.NRolePortTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_enlistedparty_port_mapping_foreign_roleporttypeid");
            });

            modelBuilder.Entity<BtsItem>(entity =>
            {
                entity.ToTable("bts_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.FullName).HasMaxLength(513);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Namespace).HasMaxLength(256);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Assembly)
                    .WithMany(p => p.BtsItem)
                    .HasForeignKey(d => d.AssemblyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bts_item_bts_assembly");
            });

            modelBuilder.Entity<BtsItemreference>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bts_itemreference");

                entity.Property(e => e.NReferringAssemblyId).HasColumnName("nReferringAssemblyID");

                entity.Property(e => e.NvcAssemblyName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcAssemblyName");

                entity.Property(e => e.NvcCulture)
                    .HasMaxLength(25)
                    .HasColumnName("nvcCulture");

                entity.Property(e => e.NvcItemName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcItemName");

                entity.Property(e => e.NvcPublicKeyToken)
                    .HasMaxLength(256)
                    .HasColumnName("nvcPublicKeyToken");

                entity.Property(e => e.NvcVersionBuild)
                    .HasMaxLength(12)
                    .HasColumnName("nvcVersionBuild");

                entity.Property(e => e.NvcVersionMajor)
                    .HasMaxLength(12)
                    .HasColumnName("nvcVersionMajor");

                entity.Property(e => e.NvcVersionMinor)
                    .HasMaxLength(12)
                    .HasColumnName("nvcVersionMinor");

                entity.Property(e => e.NvcVersionRevision)
                    .HasMaxLength(12)
                    .HasColumnName("nvcVersionRevision");
            });

            modelBuilder.Entity<BtsLibreference>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bts_libreference");

                entity.Property(e => e.Idapp).HasColumnName("idapp");

                entity.Property(e => e.Idlib).HasColumnName("idlib");

                entity.Property(e => e.RefName)
                    .HasMaxLength(256)
                    .HasColumnName("refName");

                entity.HasOne(d => d.IdappNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idapp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bts_libreference_bts_assembly");

                entity.HasOne(d => d.IdlibNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idlib)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bts_libreference_bts_assembly1");
            });

            modelBuilder.Entity<BtsMessagetype>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_messagetype");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NAssemblyId).HasColumnName("nAssemblyID");

                entity.Property(e => e.NvcFullName)
                    .HasMaxLength(513)
                    .HasColumnName("nvcFullName");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcNamespace)
                    .HasMaxLength(256)
                    .HasColumnName("nvcNamespace");
            });

            modelBuilder.Entity<BtsMessagetypePart>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_messagetype_part");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NMessageTypeId).HasColumnName("nMessageTypeID");

                entity.Property(e => e.NvcFullName)
                    .HasMaxLength(513)
                    .HasColumnName("nvcFullName");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcNamespace)
                    .HasMaxLength(256)
                    .HasColumnName("nvcNamespace");

                entity.Property(e => e.NvcSchemaUrtnameSpace)
                    .HasMaxLength(256)
                    .HasColumnName("nvcSchemaURTNameSpace");

                entity.Property(e => e.NvcSchemaUrttypeName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcSchemaURTTypeName");

                entity.HasOne(d => d.NMessageType)
                    .WithMany(p => p.BtsMessagetypePart)
                    .HasForeignKey(d => d.NMessageTypeId)
                    .HasConstraintName("FK_bts_msgtype_part_bts_messagetype");
            });

            modelBuilder.Entity<BtsOperationMsgtype>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_operation_msgtype");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NMessageTypeId).HasColumnName("nMessageTypeID");

                entity.Property(e => e.NOperationId).HasColumnName("nOperationID");

                entity.Property(e => e.NType).HasColumnName("nType");

                entity.HasOne(d => d.NOperation)
                    .WithMany(p => p.BtsOperationMsgtype)
                    .HasForeignKey(d => d.NOperationId)
                    .HasConstraintName("FK_bts_operation_msgtype_bts_porttype_operation");
            });

            modelBuilder.Entity<BtsOrchestration>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_orchestration");

                entity.HasIndex(e => e.UidGuid, "IX_bts_orchestration_GUID")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DtModified)
                    .HasColumnType("datetime")
                    .HasColumnName("dtModified");

                entity.Property(e => e.NAdminHostId).HasColumnName("nAdminHostID");

                entity.Property(e => e.NAssemblyId).HasColumnName("nAssemblyID");

                entity.Property(e => e.NItemId).HasColumnName("nItemID");

                entity.Property(e => e.NOrchestrationInfo).HasColumnName("nOrchestrationInfo");

                entity.Property(e => e.NOrchestrationStatus).HasColumnName("nOrchestrationStatus");

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(1024)
                    .HasColumnName("nvcDescription");

                entity.Property(e => e.NvcFullName)
                    .HasMaxLength(513)
                    .HasColumnName("nvcFullName");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcNamespace)
                    .HasMaxLength(256)
                    .HasColumnName("nvcNamespace");

                entity.Property(e => e.UidGuid).HasColumnName("uidGUID");

                entity.Property(e => e.UidOrchestrationType).HasColumnName("uidOrchestrationType");

                entity.HasOne(d => d.NItem)
                    .WithMany(p => p.BtsOrchestration)
                    .HasForeignKey(d => d.NItemId)
                    .HasConstraintName("fk_bts_orchestration_bts_item");
            });

            modelBuilder.Entity<BtsOrchestrationInvocation>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_orchestration_invocation");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NInvokeType).HasColumnName("nInvokeType");

                entity.Property(e => e.NInvokedOrchestrationId).HasColumnName("nInvokedOrchestrationID");

                entity.Property(e => e.NOrchestrationId).HasColumnName("nOrchestrationID");

                entity.HasOne(d => d.NOrchestration)
                    .WithMany(p => p.BtsOrchestrationInvocation)
                    .HasForeignKey(d => d.NOrchestrationId)
                    .HasConstraintName("FK_bts_orchestration_invocation_bts_orchestration");
            });

            modelBuilder.Entity<BtsOrchestrationPort>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_orchestration_port");

                entity.HasIndex(e => e.UidGuid, "IX_bts_orchestration_port")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.BLink).HasColumnName("bLink");

                entity.Property(e => e.NBindingOption).HasColumnName("nBindingOption");

                entity.Property(e => e.NOrchestrationId).HasColumnName("nOrchestrationID");

                entity.Property(e => e.NPolarity).HasColumnName("nPolarity");

                entity.Property(e => e.NPortTypeId).HasColumnName("nPortTypeID");

                entity.Property(e => e.NRolePortTypeId).HasColumnName("nRolePortTypeID");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.UidGuid).HasColumnName("uidGUID");

                entity.HasOne(d => d.NOrchestration)
                    .WithMany(p => p.BtsOrchestrationPort)
                    .HasForeignKey(d => d.NOrchestrationId)
                    .HasConstraintName("FK_bts_orchestration_port_bts_orchestration");

                entity.HasOne(d => d.NPortType)
                    .WithMany(p => p.BtsOrchestrationPort)
                    .HasForeignKey(d => d.NPortTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bts_orchestration_port_bts_porttype");
            });

            modelBuilder.Entity<BtsOrchestrationPortBinding>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_orchestration_port_unique_key");

                entity.ToTable("bts_orchestration_port_binding");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NOrcPortId).HasColumnName("nOrcPortID");

                entity.Property(e => e.NReceivePortId).HasColumnName("nReceivePortID");

                entity.Property(e => e.NSendPortId).HasColumnName("nSendPortID");

                entity.Property(e => e.NSpgId).HasColumnName("nSpgID");

                entity.HasOne(d => d.NOrcPort)
                    .WithMany(p => p.BtsOrchestrationPortBinding)
                    .HasForeignKey(d => d.NOrcPortId)
                    .HasConstraintName("bts_orcport_binding_foreign_orcportid");

                entity.HasOne(d => d.NReceivePort)
                    .WithMany(p => p.BtsOrchestrationPortBinding)
                    .HasForeignKey(d => d.NReceivePortId)
                    .HasConstraintName("bts_orchestration_port_foreign_receiveportid");

                entity.HasOne(d => d.NSendPort)
                    .WithMany(p => p.BtsOrchestrationPortBinding)
                    .HasForeignKey(d => d.NSendPortId)
                    .HasConstraintName("bts_orchestration_port_foreign_sendportid");

                entity.HasOne(d => d.NSpg)
                    .WithMany(p => p.BtsOrchestrationPortBinding)
                    .HasForeignKey(d => d.NSpgId)
                    .HasConstraintName("bts_orchestration_port_foreign_spgid");
            });

            modelBuilder.Entity<BtsParty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("bts_party");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("nID");

                entity.Property(e => e.NvcCustomData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcCustomData");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcSid)
                    .HasMaxLength(256)
                    .HasColumnName("nvcSID");

                entity.Property(e => e.NvcSignatureCert).HasColumnName("nvcSignatureCert");

                entity.Property(e => e.NvcSignatureCertHash)
                    .HasMaxLength(256)
                    .HasColumnName("nvcSignatureCertHash");
            });

            modelBuilder.Entity<BtsPartyAlias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("bts_party_alias");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NPartyId).HasColumnName("nPartyID");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcQualifier)
                    .HasMaxLength(64)
                    .HasColumnName("nvcQualifier");

                entity.Property(e => e.NvcValue)
                    .HasMaxLength(256)
                    .HasColumnName("nvcValue");
            });

            modelBuilder.Entity<BtsPartyAliasOld>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_party_alias_unique_key");

                entity.ToTable("bts_party_alias_old");

                entity.HasIndex(e => new { e.NvcQualifier, e.NvcValue }, "bts_party_alias_unique_qualifiervalue")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NPartyId).HasColumnName("nPartyID");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcQualifier)
                    .HasMaxLength(64)
                    .HasColumnName("nvcQualifier");

                entity.Property(e => e.NvcValue)
                    .HasMaxLength(256)
                    .HasColumnName("nvcValue");
            });

            modelBuilder.Entity<BtsPartyOld>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_party_unique_key");

                entity.ToTable("bts_party_old");

                entity.HasIndex(e => e.NvcName, "bts_party_unique_name")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NvcCustomData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcCustomData");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcSid)
                    .HasMaxLength(256)
                    .HasColumnName("nvcSID");

                entity.Property(e => e.NvcSignatureCert)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcSignatureCert");

                entity.Property(e => e.NvcSignatureCertHash)
                    .HasMaxLength(256)
                    .HasColumnName("nvcSignatureCertHash");
            });

            modelBuilder.Entity<BtsPartySendport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("bts_party_sendport");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NPartyId).HasColumnName("nPartyID");

                entity.Property(e => e.NSendPortId).HasColumnName("nSendPortID");

                entity.Property(e => e.NSequence).HasColumnName("nSequence");
            });

            modelBuilder.Entity<BtsPartySendportOld>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_party_sendport_unique_key");

                entity.ToTable("bts_party_sendport_old");

                entity.HasIndex(e => new { e.NPartyId, e.NSendPortId }, "bts_party_sendport_unique_key2")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NPartyId).HasColumnName("nPartyID");

                entity.Property(e => e.NSendPortId).HasColumnName("nSendPortID");

                entity.Property(e => e.NSequence).HasColumnName("nSequence");
            });

            modelBuilder.Entity<BtsPipeline>(entity =>
            {
                entity.ToTable("bts_pipeline");

                entity.HasIndex(e => e.FullyQualifiedName, "UQ__bts_pipe__22EB2CF5F3DA9D6F")
                    .IsUnique();

                entity.HasIndex(e => e.PipelineId, "UQ__bts_pipe__DD425CAE58FF9A63")
                    .IsUnique();

                entity.Property(e => e.FullyQualifiedName).HasMaxLength(256);

                entity.Property(e => e.NAssemblyId).HasColumnName("nAssemblyID");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(1024)
                    .HasColumnName("nvcDescription");

                entity.Property(e => e.PipelineId).HasColumnName("PipelineID");
            });

            modelBuilder.Entity<BtsPipelineConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bts_pipeline_config");

                entity.Property(e => e.PipelineId).HasColumnName("PipelineID");

                entity.Property(e => e.StageId).HasColumnName("StageID");
            });

            modelBuilder.Entity<BtsPipelineStage>(entity =>
            {
                entity.ToTable("bts_pipeline_stage");

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<BtsPortActivationOperation>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_port_activation_operation");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NOperationId).HasColumnName("nOperationID");

                entity.Property(e => e.NOrchestrationId).HasColumnName("nOrchestrationID");

                entity.Property(e => e.NPortId).HasColumnName("nPortID");

                entity.HasOne(d => d.NOperation)
                    .WithMany(p => p.BtsPortActivationOperation)
                    .HasForeignKey(d => d.NOperationId)
                    .HasConstraintName("FK_bts_port_activation_operation_bts_porttype_operation");

                entity.HasOne(d => d.NOrchestration)
                    .WithMany(p => p.BtsPortActivationOperation)
                    .HasForeignKey(d => d.NOrchestrationId)
                    .HasConstraintName("FK_bts_port_activation_operation_bts_orchestration");
            });

            modelBuilder.Entity<BtsPorttype>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_porttype");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NAssemblyId).HasColumnName("nAssemblyID");

                entity.Property(e => e.NvcFullName)
                    .HasMaxLength(513)
                    .HasColumnName("nvcFullName");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcNamespace)
                    .HasMaxLength(256)
                    .HasColumnName("nvcNamespace");
            });

            modelBuilder.Entity<BtsPorttypeOperation>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_porttype_operation");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NPortTypeId).HasColumnName("nPortTypeID");

                entity.Property(e => e.NType).HasColumnName("nType");

                entity.Property(e => e.NvcFullName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcFullName");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.HasOne(d => d.NPortType)
                    .WithMany(p => p.BtsPorttypeOperation)
                    .HasForeignKey(d => d.NPortTypeId)
                    .HasConstraintName("FK_bts_porttype_operation_bts_porttype");
            });

            modelBuilder.Entity<BtsReceiveport>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_receiveport_unique_key");

                entity.ToTable("bts_receiveport");

                entity.HasIndex(e => e.NvcName, "bts_receiveport_unique_name")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.BRouteFailedMessage).HasColumnName("bRouteFailedMessage");

                entity.Property(e => e.BTwoWay).HasColumnName("bTwoWay");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NApplicationId).HasColumnName("nApplicationID");

                entity.Property(e => e.NAuthentication).HasColumnName("nAuthentication");

                entity.Property(e => e.NSendPipelineId).HasColumnName("nSendPipelineId");

                entity.Property(e => e.NTracking).HasColumnName("nTracking");

                entity.Property(e => e.NvcCustomData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcCustomData");

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(1024)
                    .HasColumnName("nvcDescription");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcSendPipelineData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcSendPipelineData");

                entity.Property(e => e.UidGuid).HasColumnName("uidGUID");

                entity.HasOne(d => d.NApplication)
                    .WithMany(p => p.BtsReceiveport)
                    .HasForeignKey(d => d.NApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_receiveport_foreign_applicationid");

                entity.HasOne(d => d.NSendPipeline)
                    .WithMany(p => p.BtsReceiveport)
                    .HasForeignKey(d => d.NSendPipelineId)
                    .HasConstraintName("bts_receiveport_foreign_sendpipelineid");
            });

            modelBuilder.Entity<BtsReceiveportTransform>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_receiveport_transform_unique_key");

                entity.ToTable("bts_receiveport_transform");

                entity.HasIndex(e => new { e.NReceivePortId, e.UidTransformGuid, e.BTransmit }, "bts_receiveport_transform_unique_key2")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.BTransmit).HasColumnName("bTransmit");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NReceivePortId).HasColumnName("nReceivePortID");

                entity.Property(e => e.NSequence).HasColumnName("nSequence");

                entity.Property(e => e.UidTransformGuid).HasColumnName("uidTransformGUID");

                entity.HasOne(d => d.NReceivePort)
                    .WithMany(p => p.BtsReceiveportTransform)
                    .HasForeignKey(d => d.NReceivePortId)
                    .HasConstraintName("bts_receiveport_transform_foreign_receiveportid");

                entity.HasOne(d => d.UidTransformGu)
                    .WithMany(p => p.BtsReceiveportTransform)
                    .HasForeignKey(d => d.UidTransformGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_receiveport_transform_foreign_transformid");
            });

            modelBuilder.Entity<BtsRole>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_role");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NRoleLinkTypeId).HasColumnName("nRoleLinkTypeID");

                entity.Property(e => e.NvcFullName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcFullName");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.HasOne(d => d.NRoleLinkType)
                    .WithMany(p => p.BtsRole)
                    .HasForeignKey(d => d.NRoleLinkTypeId)
                    .HasConstraintName("FK_bts_role_bts_rolelink_type");
            });

            modelBuilder.Entity<BtsRolePorttype>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_role_porttype");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NPortTypeId).HasColumnName("nPortTypeID");

                entity.Property(e => e.NRoleId).HasColumnName("nRoleID");

                entity.HasOne(d => d.NPortType)
                    .WithMany(p => p.BtsRolePorttype)
                    .HasForeignKey(d => d.NPortTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bts_role_porttype_bts_porttype");

                entity.HasOne(d => d.NRole)
                    .WithMany(p => p.BtsRolePorttype)
                    .HasForeignKey(d => d.NRoleId)
                    .HasConstraintName("FK_bts_role_porttype_bts_role");
            });

            modelBuilder.Entity<BtsRolelink>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_rolelink");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.BImplements).HasColumnName("bImplements");

                entity.Property(e => e.NBindingType).HasColumnName("nBindingType");

                entity.Property(e => e.NOrchestrationId).HasColumnName("nOrchestrationID");

                entity.Property(e => e.NRoleId).HasColumnName("nRoleID");

                entity.Property(e => e.NvcFullName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcFullName");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.HasOne(d => d.NOrchestration)
                    .WithMany(p => p.BtsRolelink)
                    .HasForeignKey(d => d.NOrchestrationId)
                    .HasConstraintName("FK_bts_rolelink_bts_orchestration");

                entity.HasOne(d => d.NRole)
                    .WithMany(p => p.BtsRolelink)
                    .HasForeignKey(d => d.NRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bts_rolelink_bts_role");
            });

            modelBuilder.Entity<BtsRolelinkType>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("bts_rolelink_type");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.NAssemblyId).HasColumnName("nAssemblyID");

                entity.Property(e => e.NvcFullName)
                    .HasMaxLength(513)
                    .HasColumnName("nvcFullName");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcNamespace)
                    .HasMaxLength(256)
                    .HasColumnName("nvcNamespace");
            });

            modelBuilder.Entity<BtsSendport>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_sendport_unique_key");

                entity.ToTable("bts_sendport");

                entity.HasIndex(e => e.NvcName, "bts_sendport_unique_name")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.BDynamic).HasColumnName("bDynamic");

                entity.Property(e => e.BOrderedDeliveryforDynamicPort).HasColumnName("bOrderedDeliveryforDynamicPort");

                entity.Property(e => e.BRouteFailedMessage).HasColumnName("bRouteFailedMessage");

                entity.Property(e => e.BStopSendingOnFailure).HasColumnName("bStopSendingOnFailure");

                entity.Property(e => e.BTwoWay).HasColumnName("bTwoWay");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NApplicationId).HasColumnName("nApplicationID");

                entity.Property(e => e.NApplicationTypeId).HasColumnName("nApplicationTypeId");

                entity.Property(e => e.NPortStatus).HasColumnName("nPortStatus");

                entity.Property(e => e.NPriority).HasColumnName("nPriority");

                entity.Property(e => e.NReceivePipelineId).HasColumnName("nReceivePipelineID");

                entity.Property(e => e.NSendPipelineId).HasColumnName("nSendPipelineID");

                entity.Property(e => e.NTracking).HasColumnName("nTracking");

                entity.Property(e => e.NvcApplicationTypeData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcApplicationTypeData");

                entity.Property(e => e.NvcCustomData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcCustomData");

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(1024)
                    .HasColumnName("nvcDescription");

                entity.Property(e => e.NvcEncryptionCert)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcEncryptionCert");

                entity.Property(e => e.NvcEncryptionCertHash)
                    .HasMaxLength(256)
                    .HasColumnName("nvcEncryptionCertHash");

                entity.Property(e => e.NvcFilter)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcFilter");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.NvcReceivePipelineData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcReceivePipelineData");

                entity.Property(e => e.NvcSendPipelineData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcSendPipelineData");

                entity.Property(e => e.UidGuid).HasColumnName("uidGUID");

                entity.HasOne(d => d.NApplication)
                    .WithMany(p => p.BtsSendport)
                    .HasForeignKey(d => d.NApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_sendport_foreign_applicationid");

                entity.HasOne(d => d.NReceivePipeline)
                    .WithMany(p => p.BtsSendportNReceivePipeline)
                    .HasForeignKey(d => d.NReceivePipelineId)
                    .HasConstraintName("bts_sendport_foreign_receivepipelineid");

                entity.HasOne(d => d.NSendPipeline)
                    .WithMany(p => p.BtsSendportNSendPipeline)
                    .HasForeignKey(d => d.NSendPipelineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_sendport_foreign_sendpipelineid");
            });

            modelBuilder.Entity<BtsSendportTransform>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_sendport_transform_unique_key");

                entity.ToTable("bts_sendport_transform");

                entity.HasIndex(e => new { e.NSendPortId, e.UidTransformGuid, e.BReceive }, "bts_sendport_transform_unique_key2")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.BReceive).HasColumnName("bReceive");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NSendPortId).HasColumnName("nSendPortID");

                entity.Property(e => e.NSequence).HasColumnName("nSequence");

                entity.Property(e => e.UidTransformGuid).HasColumnName("uidTransformGUID");

                entity.HasOne(d => d.NSendPort)
                    .WithMany(p => p.BtsSendportTransform)
                    .HasForeignKey(d => d.NSendPortId)
                    .HasConstraintName("bts_sendport_transform_foreign_sendportid");

                entity.HasOne(d => d.UidTransformGu)
                    .WithMany(p => p.BtsSendportTransform)
                    .HasForeignKey(d => d.UidTransformGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_sendport_transform_foreign_transformid");
            });

            modelBuilder.Entity<BtsSendportTransport>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_sendport_transport_unique_key");

                entity.ToTable("bts_sendport_transport");

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.BIsPrimary).HasColumnName("bIsPrimary");

                entity.Property(e => e.BIsServiceWindow).HasColumnName("bIsServiceWindow");

                entity.Property(e => e.BOrderedDelivery).HasColumnName("bOrderedDelivery");

                entity.Property(e => e.BSsomappingExists).HasColumnName("bSSOMappingExists");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DtFromTime)
                    .HasColumnType("datetime")
                    .HasColumnName("dtFromTime");

                entity.Property(e => e.DtToTime)
                    .HasColumnType("datetime")
                    .HasColumnName("dtToTime");

                entity.Property(e => e.NDeliveryNotification).HasColumnName("nDeliveryNotification");

                entity.Property(e => e.NRetryCount).HasColumnName("nRetryCount");

                entity.Property(e => e.NRetryInterval).HasColumnName("nRetryInterval");

                entity.Property(e => e.NSendHandlerId).HasColumnName("nSendHandlerID");

                entity.Property(e => e.NSendPortId).HasColumnName("nSendPortID");

                entity.Property(e => e.NTransportTypeId).HasColumnName("nTransportTypeId");

                entity.Property(e => e.NvcAddress)
                    .HasMaxLength(256)
                    .HasColumnName("nvcAddress");

                entity.Property(e => e.NvcTransportTypeData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcTransportTypeData");

                entity.Property(e => e.UidGuid).HasColumnName("uidGUID");

                entity.HasOne(d => d.NSendHandler)
                    .WithMany(p => p.BtsSendportTransport)
                    .HasForeignKey(d => d.NSendHandlerId)
                    .HasConstraintName("bts_sendport_transport_foreign_sendhandlerid");

                entity.HasOne(d => d.NSendPort)
                    .WithMany(p => p.BtsSendportTransport)
                    .HasForeignKey(d => d.NSendPortId)
                    .HasConstraintName("bts_sendport_transport_foreign_ownerid");

                entity.HasOne(d => d.NTransportType)
                    .WithMany(p => p.BtsSendportTransport)
                    .HasForeignKey(d => d.NTransportTypeId)
                    .HasConstraintName("bts_sendport_transport_foreign_transporttypeid");
            });

            modelBuilder.Entity<BtsSendportgroup>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_spg_unique_key");

                entity.ToTable("bts_sendportgroup");

                entity.HasIndex(e => e.NvcName, "bts_spg_unique_name")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NApplicationId).HasColumnName("nApplicationID");

                entity.Property(e => e.NPortStatus).HasColumnName("nPortStatus");

                entity.Property(e => e.NvcCustomData)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcCustomData");

                entity.Property(e => e.NvcDescription)
                    .HasMaxLength(1024)
                    .HasColumnName("nvcDescription");

                entity.Property(e => e.NvcFilter)
                    .HasColumnType("ntext")
                    .HasColumnName("nvcFilter");

                entity.Property(e => e.NvcName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcName");

                entity.Property(e => e.UidGuid).HasColumnName("uidGUID");

                entity.HasOne(d => d.NApplication)
                    .WithMany(p => p.BtsSendportgroup)
                    .HasForeignKey(d => d.NApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_sendportgroup_foreign_applicationid");
            });

            modelBuilder.Entity<BtsSpgSendport>(entity =>
            {
                entity.HasKey(e => e.NId)
                    .HasName("bts_spg_sendport_unique_key");

                entity.ToTable("bts_spg_sendport");

                entity.HasIndex(e => new { e.NSendPortGroupId, e.NSendPortId }, "bts_spg_sendport_unique_key2")
                    .IsUnique();

                entity.Property(e => e.NId).HasColumnName("nID");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.NSendPortGroupId).HasColumnName("nSendPortGroupID");

                entity.Property(e => e.NSendPortId).HasColumnName("nSendPortID");

                entity.Property(e => e.NSequence).HasColumnName("nSequence");

                entity.Property(e => e.UidPrimaryGuid).HasColumnName("uidPrimaryGUID");

                entity.Property(e => e.UidSecondaryGuid).HasColumnName("uidSecondaryGUID");

                entity.HasOne(d => d.NSendPortGroup)
                    .WithMany(p => p.BtsSpgSendport)
                    .HasForeignKey(d => d.NSendPortGroupId)
                    .HasConstraintName("bts_spg_sendport_foreign_spgid");

                entity.HasOne(d => d.NSendPort)
                    .WithMany(p => p.BtsSpgSendport)
                    .HasForeignKey(d => d.NSendPortId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bts_spg_sendport_foreign_sendportid");
            });

            modelBuilder.Entity<BtsStageConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bts_stage_config");

                entity.Property(e => e.CompId).HasColumnName("CompID");

                entity.Property(e => e.StageId).HasColumnName("StageID");
            });

            modelBuilder.Entity<BtsmonInconsistancies>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("btsmon_Inconsistancies");

                entity.Property(e => e.Dbname)
                    .HasMaxLength(128)
                    .HasColumnName("DBName");

                entity.Property(e => e.Dbserver)
                    .HasMaxLength(128)
                    .HasColumnName("DBServer");

                entity.Property(e => e.NCount).HasColumnName("nCount");

                entity.Property(e => e.NProblemCode).HasColumnName("nProblemCode");
            });

            modelBuilder.Entity<BtsmonIssues>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("btsmon_Issues");

                entity.Property(e => e.NProblemCode).HasColumnName("nProblemCode");

                entity.Property(e => e.NvcProblemDescription)
                    .HasMaxLength(128)
                    .HasColumnName("nvcProblemDescription");
            });

            modelBuilder.Entity<BtsvVersionIndependentOrchestration>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("btsv_VersionIndependentOrchestration");

                entity.Property(e => e.DtDateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDateModified");

                entity.Property(e => e.NAdminGroupId).HasColumnName("nAdminGroupId");

                entity.Property(e => e.NAdminHostId).HasColumnName("nAdminHostID");

                entity.Property(e => e.NOrchestrationId).HasColumnName("nOrchestrationID");

                entity.Property(e => e.NOrchestrationStatus).HasColumnName("nOrchestrationStatus");

                entity.Property(e => e.NvcAssemblyCulture)
                    .HasMaxLength(256)
                    .HasColumnName("nvcAssemblyCulture");

                entity.Property(e => e.NvcAssemblyFullName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcAssemblyFullName");

                entity.Property(e => e.NvcAssemblyName)
                    .HasMaxLength(256)
                    .HasColumnName("nvcAssemblyName");

                entity.Property(e => e.NvcAssemblyPublicKeyToken)
                    .HasMaxLength(256)
                    .HasColumnName("nvcAssemblyPublicKeyToken");

                entity.Property(e => e.NvcOrchestrationName)
                    .HasMaxLength(513)
                    .HasColumnName("nvcOrchestrationName");
            });

            modelBuilder.Entity<BusinessIdentity>(entity =>
            {
                entity.ToTable("BusinessIdentity", "tpm");

                entity.HasIndex(e => new { e.ProfileId, e.Qualifier, e.Value }, "UK_Qualifier_Value_NonNullProfile")
                    .IsUnique();

                entity.Property(e => e.AdditionalData).HasMaxLength(256);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Qualifier).HasMaxLength(64);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.BusinessIdentity)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BusinessIdentity_BusinessProfile");
            });

            modelBuilder.Entity<BusinessProfile>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.ToTable("BusinessProfile", "tpm");

                entity.HasIndex(e => new { e.PartnerId, e.Name }, "UK_ProfileName")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.BusinessProfile)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessProfile_Partner");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact", "tpm");

                entity.Property(e => e.Address).HasMaxLength(512);

                entity.Property(e => e.BusinessPhone).HasMaxLength(256);

                entity.Property(e => e.Company).HasMaxLength(256);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Fax).HasMaxLength(256);

                entity.Property(e => e.JobTitle).HasMaxLength(256);

                entity.Property(e => e.MobilePhone).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Notes).HasMaxLength(1024);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.Property(e => e.WebAddress).HasMaxLength(256);

                entity.HasOne(d => d.Agreement)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.AgreementId)
                    .HasConstraintName("FK_Contact_Agreement");
            });

            modelBuilder.Entity<CustomSettings>(entity =>
            {
                entity.ToTable("CustomSettings", "tpm");

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");
            });

            modelBuilder.Entity<EdiDbConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("edi_DbConfig");

                entity.Property(e => e.As2configured).HasColumnName("AS2Configured");

                entity.Property(e => e.As2enabled).HasColumnName("AS2Enabled");

                entity.Property(e => e.EdiRuntimeDbName).HasMaxLength(128);

                entity.Property(e => e.EdiRuntimeDbServerName).HasMaxLength(80);

                entity.Property(e => e.SsoApplicationName).HasMaxLength(256);
            });

            modelBuilder.Entity<EdifactenvelopeOverrides>(entity =>
            {
                entity.HasKey(e => e.OverridesId);

                entity.ToTable("EDIFACTEnvelopeOverrides", "tpm");

                entity.HasIndex(e => new { e.SettingsId, e.MessageId, e.MessageVersion, e.MessageRelease, e.MessageAssociationAssignedCode, e.TargetNamespace }, "UK_EDIFACTEnvelopeOverrides")
                    .IsUnique();

                entity.Property(e => e.AssociationAssignedCode).HasMaxLength(6);

                entity.Property(e => e.ControllingAgencyCode).HasMaxLength(6);

                entity.Property(e => e.FunctionalGroupId).HasMaxLength(6);

                entity.Property(e => e.GroupHeaderMessageRelease).HasMaxLength(6);

                entity.Property(e => e.GroupHeaderMessageVersion).HasMaxLength(6);

                entity.Property(e => e.MessageAssociationAssignedCode).HasMaxLength(6);

                entity.Property(e => e.MessageId).HasMaxLength(15);

                entity.Property(e => e.MessageRelease).HasMaxLength(6);

                entity.Property(e => e.MessageVersion).HasMaxLength(6);

                entity.Property(e => e.ReceiverApplicationId).HasMaxLength(35);

                entity.Property(e => e.ReceiverApplicationQualifier).HasMaxLength(15);

                entity.Property(e => e.SenderApplicationId).HasMaxLength(35);

                entity.Property(e => e.SenderApplicationQualifier).HasMaxLength(15);

                entity.Property(e => e.Ssoidentifier).HasColumnName("SSOIdentifier");

                entity.Property(e => e.TargetNamespace).HasMaxLength(230);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithMany(p => p.EdifactenvelopeOverrides)
                    .HasForeignKey(d => d.SettingsId)
                    .HasConstraintName("FK_EDIFACTEnvelopeOverrides_EDIFACTProtocolSettings");
            });

            modelBuilder.Entity<EdifactmessageFilterList>(entity =>
            {
                entity.HasKey(e => e.FilterListId);

                entity.ToTable("EDIFACTMessageFilterList", "tpm");

                entity.HasIndex(e => new { e.SettingsId, e.MessageId }, "UK_EDIFACTMessageFilterList")
                    .IsUnique();

                entity.Property(e => e.MessageId).HasMaxLength(8);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithMany(p => p.EdifactmessageFilterList)
                    .HasForeignKey(d => d.SettingsId)
                    .HasConstraintName("FK_EDIFACTMessageFilterList_ProtocolSettings");
            });

            modelBuilder.Entity<EdifactprotocolSettings>(entity =>
            {
                entity.HasKey(e => e.SettingsId);

                entity.ToTable("EDIFACTProtocolSettings", "tpm");

                entity.Property(e => e.SettingsId).ValueGeneratedNever();

                entity.Property(e => e.AcknowledgementControlNumberPrefix).HasMaxLength(14);

                entity.Property(e => e.AcknowledgementControlNumberSuffix).HasMaxLength(14);

                entity.Property(e => e.ApplicationReferenceId).HasMaxLength(15);

                entity.Property(e => e.CharacterEncoding).HasMaxLength(3);

                entity.Property(e => e.CommunicationAgreementId).HasMaxLength(40);

                entity.Property(e => e.FunctionalGroupId).HasMaxLength(6);

                entity.Property(e => e.GroupApplicationReceiverId).HasMaxLength(35);

                entity.Property(e => e.GroupApplicationReceiverQualifier).HasMaxLength(15);

                entity.Property(e => e.GroupApplicationSenderId).HasMaxLength(35);

                entity.Property(e => e.GroupApplicationSenderQualifier).HasMaxLength(15);

                entity.Property(e => e.GroupAssociationAssignedCode).HasMaxLength(6);

                entity.Property(e => e.GroupControlNumberPrefix).HasMaxLength(14);

                entity.Property(e => e.GroupControlNumberSuffix).HasMaxLength(14);

                entity.Property(e => e.GroupControllingAgencyCode).HasMaxLength(6);

                entity.Property(e => e.GroupMessageRelease).HasMaxLength(6);

                entity.Property(e => e.GroupMessageVersion).HasMaxLength(6);

                entity.Property(e => e.InterchangeControlNumberPrefix).HasMaxLength(14);

                entity.Property(e => e.InterchangeControlNumberSuffix).HasMaxLength(14);

                entity.Property(e => e.ProcessingPriorityCode).HasMaxLength(1);

                entity.Property(e => e.ReceiverInternalIdentification).HasMaxLength(35);

                entity.Property(e => e.ReceiverInternalSubIdentification).HasMaxLength(35);

                entity.Property(e => e.ReceiverReverseRoutingAddress).HasMaxLength(15);

                entity.Property(e => e.SenderInternalIdentification).HasMaxLength(35);

                entity.Property(e => e.SenderInternalSubIdentification).HasMaxLength(35);

                entity.Property(e => e.SenderReverseRoutingAddress).HasMaxLength(15);

                entity.Property(e => e.ServiceCodeListDirectoryVersion).HasMaxLength(6);

                entity.Property(e => e.Ssoidentifier).HasColumnName("SSOIdentifier");

                entity.Property(e => e.TargetNamespace).HasMaxLength(230);

                entity.Property(e => e.TsapplyNewId).HasColumnName("TSApplyNewId");

                entity.Property(e => e.TscontrolNumberLowerBound).HasColumnName("TSControlNumberLowerBound");

                entity.Property(e => e.TscontrolNumberPrefix)
                    .HasMaxLength(14)
                    .HasColumnName("TSControlNumberPrefix");

                entity.Property(e => e.TscontrolNumberRollover).HasColumnName("TSControlNumberRollover");

                entity.Property(e => e.TscontrolNumberSuffix)
                    .HasMaxLength(14)
                    .HasColumnName("TSControlNumberSuffix");

                entity.Property(e => e.TscontrolNumberUpperBound).HasColumnName("TSControlNumberUpperBound");

                entity.Property(e => e.ValidateEditypes).HasColumnName("ValidateEDITypes");

                entity.Property(e => e.ValidateXsdtypes).HasColumnName("ValidateXSDTypes");

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithOne(p => p.EdifactprotocolSettings)
                    .HasForeignKey<EdifactprotocolSettings>(d => d.SettingsId)
                    .HasConstraintName("FK_EDIFACTProtocolSettings_ProtocolSettings");
            });

            modelBuilder.Entity<EdifactschemaOverrides>(entity =>
            {
                entity.HasKey(e => e.OverridesId);

                entity.ToTable("EDIFACTSchemaOverrides", "tpm");

                entity.HasIndex(e => new { e.SettingsId, e.MessageId, e.MessageVersion, e.MessageRelease, e.ApplicationSenderId, e.ApplicationSenderQualifier, e.AssociationAssignedCode }, "UK_EDIFACTSchemaOverrides")
                    .IsUnique();

                entity.Property(e => e.ApplicationSenderId)
                    .HasMaxLength(15)
                    .HasColumnName("ApplicationSenderID");

                entity.Property(e => e.ApplicationSenderQualifier).HasMaxLength(15);

                entity.Property(e => e.AssociationAssignedCode).HasMaxLength(6);

                entity.Property(e => e.MessageId).HasMaxLength(15);

                entity.Property(e => e.MessageRelease).HasMaxLength(6);

                entity.Property(e => e.MessageVersion).HasMaxLength(6);

                entity.Property(e => e.TargetNamespace).HasMaxLength(230);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithMany(p => p.EdifactschemaOverrides)
                    .HasForeignKey(d => d.SettingsId)
                    .HasConstraintName("FK_EDIFACTSchemaOverrides_EDIFACTProtocolSettings");
            });

            modelBuilder.Entity<EdifactvalidationOverrides>(entity =>
            {
                entity.HasKey(e => e.OverridesId);

                entity.ToTable("EDIFACTValidationOverrides", "tpm");

                entity.HasIndex(e => new { e.SettingsId, e.MessageId }, "UK_EDIFACTValidationOverrides")
                    .IsUnique();

                entity.Property(e => e.MessageId).HasMaxLength(15);

                entity.Property(e => e.ValidateEditypes).HasColumnName("ValidateEDITypes");

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithMany(p => p.EdifactvalidationOverrides)
                    .HasForeignKey(d => d.SettingsId)
                    .HasConstraintName("FK_EDIFACTValidationOverrides_EDIFACTProtocolSettings");
            });

            modelBuilder.Entity<Edix12st01gs01mapping>(entity =>
            {
                entity.HasKey(e => e.St01);

                entity.ToTable("EDIX12ST01GS01Mapping");

                entity.Property(e => e.St01)
                    .HasMaxLength(50)
                    .HasColumnName("ST01");

                entity.Property(e => e.Gs01)
                    .HasMaxLength(50)
                    .HasColumnName("GS01");
            });

            modelBuilder.Entity<FallbackSettings>(entity =>
            {
                entity.ToTable("FallbackSettings", "tpm");

                entity.HasIndex(e => e.ProtocolName, "UK_FallbackSettings")
                    .IsUnique();

                entity.Property(e => e.ProtocolName).HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.ProtocolSettings)
                    .WithMany(p => p.FallbackSettings)
                    .HasForeignKey(d => d.ProtocolSettingsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FallbackSettings_ProtocolSettings");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.FallbackSettingsReceiver)
                    .HasForeignKey(d => d.ReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FallbackSettings_ReceiverIdentity");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.FallbackSettingsSender)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FallbackSettings_SenderIdentity");
            });

            modelBuilder.Entity<MarkLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MarkName).HasMaxLength(128);
            });

            modelBuilder.Entity<OnewayAgreement>(entity =>
            {
                entity.ToTable("OnewayAgreement", "tpm");

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.ProtocolSettings)
                    .WithMany(p => p.OnewayAgreement)
                    .HasForeignKey(d => d.ProtocolSettingsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnewayAgreement_ProtocolSettings");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.OnewayAgreementReceiver)
                    .HasForeignKey(d => d.ReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnewayAgreement_ReceiverIdentity");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.OnewayAgreementSender)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnewayAgreement_SenderIdentity");

                entity.HasMany(d => d.SendPortReference)
                    .WithMany(p => p.OnewayAgreement)
                    .UsingEntity<Dictionary<string, object>>(
                        "OnewayAgreementSendPortReference",
                        l => l.HasOne<SendPortReference>().WithMany().HasForeignKey("SendPortReferenceId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_OnewayAgreementSendPortReference_SendPortReference"),
                        r => r.HasOne<OnewayAgreement>().WithMany().HasForeignKey("OnewayAgreementId").HasConstraintName("FK_OnewayAgreementSendPortReference_OnewayAgreement"),
                        j =>
                        {
                            j.HasKey("OnewayAgreementId", "SendPortReferenceId");

                            j.ToTable("OnewayAgreementSendPortReference", "tpm");
                        });
            });

            modelBuilder.Entity<PamBatchingLog>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.ToTable("PAM_Batching_Log");

                entity.Property(e => e.BatchId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PamControl>(entity =>
            {
                entity.HasKey(e => new { e.UsedOnce, e.BatchId });

                entity.ToTable("PAM_Control");

                entity.Property(e => e.ActionDateTime).HasColumnType("datetime");

                entity.Property(e => e.ActionType).HasMaxLength(50);

                entity.Property(e => e.AgreementName).HasMaxLength(256);

                entity.Property(e => e.BatchName).HasMaxLength(256);

                entity.Property(e => e.ReceiverPartyName).HasMaxLength(256);

                entity.Property(e => e.SenderPartyName).HasMaxLength(256);

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.PamControl)
                    .HasForeignKey(d => d.BatchId)
                    .HasConstraintName("FK_PAM_Control");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.ToTable("Partner", "tpm");

                entity.HasIndex(e => e.CertificateHash, "UK_CertificateHash_NonNull")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "UK_PartnerName")
                    .IsUnique();

                entity.Property(e => e.CertificateHash).HasMaxLength(256);

                entity.Property(e => e.CustomData).HasColumnType("ntext");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Sid)
                    .HasMaxLength(256)
                    .HasColumnName("SID");

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");
            });

            modelBuilder.Entity<Partnership>(entity =>
            {
                entity.ToTable("Partnership", "tpm");

                entity.Property(e => e.PartnerAid).HasColumnName("PartnerAId");

                entity.Property(e => e.PartnerBid).HasColumnName("PartnerBId");

                entity.HasOne(d => d.PartnerA)
                    .WithMany(p => p.PartnershipPartnerA)
                    .HasForeignKey(d => d.PartnerAid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partnership_PartnerA");

                entity.HasOne(d => d.PartnerB)
                    .WithMany(p => p.PartnershipPartnerB)
                    .HasForeignKey(d => d.PartnerBid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partnership_PartnerB");
            });

            modelBuilder.Entity<ProtocolSettings>(entity =>
            {
                entity.ToTable("ProtocolSettings", "tpm");

                entity.HasIndex(e => new { e.ProfileId, e.SettingsName }, "UK_Profile_SettingsName")
                    .IsUnique();

                entity.Property(e => e.ProtocolName).HasMaxLength(50);

                entity.Property(e => e.SettingsName).HasMaxLength(256);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProtocolSettings)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProtocolSettings_BusinessProfile");
            });

            modelBuilder.Entity<SendPortReference>(entity =>
            {
                entity.ToTable("SendPortReference", "tpm");

                entity.HasIndex(e => new { e.PartnerId, e.Name }, "UK_SendPortName")
                    .IsUnique();

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.SendPortReference)
                    .HasPrincipalKey(p => p.NvcName)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SendPortReference_BTSSendPort");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.SendPortReference)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_SendPortReference_Partner");
            });

            modelBuilder.Entity<StaticTrackingInfo>(entity =>
            {
                entity.HasKey(e => new { e.UidServiceId, e.UidInterceptorId })
                    .HasName("adm_StaticTrackingInfo_pk");

                entity.Property(e => e.UidServiceId).HasColumnName("uidServiceId");

                entity.Property(e => e.UidInterceptorId).HasColumnName("uidInterceptorId");

                entity.Property(e => e.DtDeploymentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDeploymentTime");

                entity.Property(e => e.DtUndeploymentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("dtUndeploymentTime");

                entity.Property(e => e.ImgData)
                    .HasColumnType("image")
                    .HasColumnName("imgData");

                entity.Property(e => e.IsmsgBodyTrackingEnabled).HasColumnName("ismsgBodyTrackingEnabled");

                entity.Property(e => e.StrServiceName)
                    .HasMaxLength(256)
                    .HasColumnName("strServiceName");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.StaticTrackingInfo)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("StaticTrackingInfo_fk_group");
            });

            modelBuilder.Entity<TddsCustomFormats>(entity =>
            {
                entity.HasKey(e => e.FormatId)
                    .HasName("PK__TDDS_Cus__5D3DCB7934A37F84");

                entity.ToTable("TDDS_CustomFormats");

                entity.Property(e => e.FormatId)
                    .ValueGeneratedNever()
                    .HasColumnName("FormatID");

                entity.Property(e => e.DecoderClass).HasMaxLength(256);

                entity.Property(e => e.DllName).HasMaxLength(1024);
            });

            modelBuilder.Entity<TddsDestinations>(entity =>
            {
                entity.HasKey(e => e.DestinationId)
                    .HasName("PK__TDDS_Des__DB5FE4ACAC6D7E78");

                entity.ToTable("TDDS_Destinations");

                entity.Property(e => e.DestinationId)
                    .ValueGeneratedNever()
                    .HasColumnName("DestinationID");

                entity.Property(e => e.ConnectionString).HasMaxLength(1024);

                entity.Property(e => e.DestinationName).HasMaxLength(256);
            });

            modelBuilder.Entity<TddsHeartbeats>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TDDS_Heartbeats");

                entity.HasIndex(e => new { e.ServiceId, e.SourceId }, "TDDS_HeartBeatClusteredIndex")
                    .IsClustered();

                entity.HasIndex(e => e.Age, "TDDS_HeartBeatNonClusteredIndex");

                entity.Property(e => e.Age).ValueGeneratedOnAdd();

                entity.Property(e => e.ErrorDescription).HasMaxLength(1024);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TimeLastChanged).HasColumnType("datetime");

                entity.HasOne(d => d.Service)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TDDS_Hear__Servi__403A8C7D");
            });

            modelBuilder.Entity<TddsServices>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__TDDS_Ser__C51BB0EAE6B7C486");

                entity.ToTable("TDDS_Services");

                entity.Property(e => e.ServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("ServiceID");

                entity.Property(e => e.ServerName).HasMaxLength(32);
            });

            modelBuilder.Entity<TddsSettings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TDDS_Settings");

                entity.Property(e => e.EventLoggingInterval).HasMaxLength(16);
            });

            modelBuilder.Entity<TddsSources>(entity =>
            {
                entity.HasKey(e => e.SourceId)
                    .HasName("PK__TDDS_Sou__16E019F92E675273");

                entity.ToTable("TDDS_Sources");

                entity.Property(e => e.SourceId)
                    .ValueGeneratedNever()
                    .HasColumnName("SourceID");

                entity.Property(e => e.ConnectionString).HasMaxLength(1024);

                entity.Property(e => e.DestinationId).HasColumnName("DestinationID");

                entity.Property(e => e.SourceName).HasMaxLength(256);

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.TddsSources)
                    .HasForeignKey(d => d.DestinationId)
                    .HasConstraintName("FK__TDDS_Sour__Desti__3B75D760");
            });

            modelBuilder.Entity<TestSettings>(entity =>
            {
                entity.ToTable("TestSettings", "tpm");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ReceiveSetting).HasMaxLength(50);

                entity.Property(e => e.SendSetting).HasMaxLength(50);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.TestSettings)
                    .HasForeignKey<TestSettings>(d => d.Id)
                    .HasConstraintName("FK_TestSettings_ProtocolSettings");
            });

            modelBuilder.Entity<Trackinginterceptor>(entity =>
            {
                entity.HasKey(e => e.UidInterceptorId)
                    .HasName("adm_Trackinginterceptor_pk");

                entity.Property(e => e.UidInterceptorId)
                    .ValueGeneratedNever()
                    .HasColumnName("uidInterceptorID");

                entity.Property(e => e.AssemblyName).HasMaxLength(256);

                entity.Property(e => e.TypeName).HasMaxLength(256);
            });

            modelBuilder.Entity<TrackinginterceptorVersions>(entity =>
            {
                entity.HasKey(e => e.UidInterceptorId)
                    .HasName("adm_TrackinginterceptorVersions_idx_version");

                entity.Property(e => e.UidInterceptorId)
                    .ValueGeneratedNever()
                    .HasColumnName("uidInterceptorID");

                entity.Property(e => e.AssemblyName).HasMaxLength(1024);

                entity.Property(e => e.DtDeploymentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDeploymentTime");

                entity.Property(e => e.TypeName).HasMaxLength(256);

                entity.Property(e => e.UidRootInterceptorId).HasColumnName("uidRootInterceptorID");

                entity.HasOne(d => d.UidRootInterceptor)
                    .WithMany(p => p.TrackinginterceptorVersions)
                    .HasForeignKey(d => d.UidRootInterceptorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("adm_TrackinginterceptorVersions_fk_id");
            });

            modelBuilder.Entity<X12envelopesOverrides>(entity =>
            {
                entity.HasKey(e => e.OverridesId);

                entity.ToTable("X12EnvelopesOverrides", "tpm");

                entity.HasIndex(e => new { e.SettingsId, e.TargetNamespace, e.ProtocolVersion, e.MessageId }, "UK_X12EnvelopesOverrides")
                    .IsUnique();

                entity.Property(e => e.FunctionalIdentifierCode).HasMaxLength(15);

                entity.Property(e => e.HeaderVersion).HasMaxLength(12);

                entity.Property(e => e.MessageId).HasMaxLength(5);

                entity.Property(e => e.ProtocolVersion).HasMaxLength(5);

                entity.Property(e => e.ReceiverApplicationId).HasMaxLength(15);

                entity.Property(e => e.SenderApplicationId).HasMaxLength(15);

                entity.Property(e => e.TargetNamespace).HasMaxLength(230);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithMany(p => p.X12envelopesOverrides)
                    .HasForeignKey(d => d.SettingsId)
                    .HasConstraintName("FK_X12EnvelopesOverrrides_X12ProtocolSettings");
            });

            modelBuilder.Entity<X12messageFilterList>(entity =>
            {
                entity.HasKey(e => e.FilterListId);

                entity.ToTable("X12MessageFilterList", "tpm");

                entity.HasIndex(e => new { e.SettingsId, e.MessageId }, "UK_X12MessageFilterList")
                    .IsUnique();

                entity.Property(e => e.MessageId).HasMaxLength(5);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithMany(p => p.X12messageFilterList)
                    .HasForeignKey(d => d.SettingsId)
                    .HasConstraintName("FK_X12MessageFilterList_X12ProtocolSettings");
            });

            modelBuilder.Entity<X12protocolSettings>(entity =>
            {
                entity.HasKey(e => e.SettingsId);

                entity.ToTable("X12ProtocolSettings", "tpm");

                entity.Property(e => e.SettingsId).ValueGeneratedNever();

                entity.Property(e => e.AcknowledgementControlNumberPrefix).HasMaxLength(9);

                entity.Property(e => e.AcknowledgementControlNumberSuffix).HasMaxLength(9);

                entity.Property(e => e.ControlStandardsId).HasColumnName("ControlStandardsID");

                entity.Property(e => e.ControlVersionNumber).HasMaxLength(5);

                entity.Property(e => e.FunctionalAckVersion).HasMaxLength(5);

                entity.Property(e => e.FunctionalGroupId).HasMaxLength(15);

                entity.Property(e => e.GeneratePatAk901).HasColumnName("GeneratePatAK901");

                entity.Property(e => e.GroupHeaderVersion).HasMaxLength(12);

                entity.Property(e => e.ImplementationAckVersion).HasMaxLength(5);

                entity.Property(e => e.ReceiverApplicationId).HasMaxLength(15);

                entity.Property(e => e.SenderApplicationId).HasMaxLength(15);

                entity.Property(e => e.Ssoidentifier).HasColumnName("SSOIdentifier");

                entity.Property(e => e.TargetNamespace).HasMaxLength(230);

                entity.Property(e => e.TsapplyNewId).HasColumnName("TSApplyNewId");

                entity.Property(e => e.TscontrolNumberLowerBound).HasColumnName("TSControlNumberLowerBound");

                entity.Property(e => e.TscontrolNumberPrefix)
                    .HasMaxLength(9)
                    .HasColumnName("TSControlNumberPrefix");

                entity.Property(e => e.TscontrolNumberRollover).HasColumnName("TSControlNumberRollover");

                entity.Property(e => e.TscontrolNumberSuffix)
                    .HasMaxLength(9)
                    .HasColumnName("TSControlNumberSuffix");

                entity.Property(e => e.TscontrolNumberUpperBound).HasColumnName("TSControlNumberUpperBound");

                entity.Property(e => e.UseControlStandardsIdasRepSep).HasColumnName("UseControlStandardsIDAsRepSep");

                entity.Property(e => e.ValidateEditypes).HasColumnName("ValidateEDITypes");

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithOne(p => p.X12protocolSettings)
                    .HasForeignKey<X12protocolSettings>(d => d.SettingsId)
                    .HasConstraintName("FK_X12ProtocolSettings_ProtocolSettings");
            });

            modelBuilder.Entity<X12schemaOverrides>(entity =>
            {
                entity.HasKey(e => e.OverridesId)
                    .HasName("PK_X12SchemasOverrides");

                entity.ToTable("X12SchemaOverrides", "tpm");

                entity.HasIndex(e => new { e.SettingsId, e.MessageId, e.SenderApplicationId }, "UK_X12SchemaOverrides")
                    .IsUnique();

                entity.Property(e => e.GstargetNamespace)
                    .HasMaxLength(230)
                    .HasColumnName("GSTargetNamespace");

                entity.Property(e => e.MessageId).HasMaxLength(5);

                entity.Property(e => e.SenderApplicationId).HasMaxLength(15);

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithMany(p => p.X12schemaOverrides)
                    .HasForeignKey(d => d.SettingsId)
                    .HasConstraintName("FK_X12SchemaOverrides_X12ProtocolSettings");
            });

            modelBuilder.Entity<X12validationOverrides>(entity =>
            {
                entity.HasKey(e => e.OverridesId);

                entity.ToTable("X12ValidationOverrides", "tpm");

                entity.HasIndex(e => new { e.SettingsId, e.MessageId }, "UK_X12ValidationOverridesKey")
                    .IsUnique();

                entity.Property(e => e.MessageId).HasMaxLength(5);

                entity.Property(e => e.ValidateEditypes).HasColumnName("ValidateEDITypes");

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");

                entity.HasOne(d => d.Settings)
                    .WithMany(p => p.X12validationOverrides)
                    .HasForeignKey(d => d.SettingsId)
                    .HasConstraintName("FK_X12ValidationOverrides_X12ProtocolSettings");
            });

            modelBuilder.Entity<XrefAppInstance>(entity =>
            {
                entity.HasKey(e => e.AppInstanceId)
                    .HasName("PK_xref_appInstance");

                entity.ToTable("xref_AppInstance");

                entity.HasIndex(e => e.AppInstance, "IX_AppInst1");

                entity.Property(e => e.AppInstanceId).HasColumnName("appInstanceID");

                entity.Property(e => e.AppInstance)
                    .HasMaxLength(50)
                    .HasColumnName("appInstance");

                entity.Property(e => e.AppTypeId).HasColumnName("appTypeID");
            });

            modelBuilder.Entity<XrefAppType>(entity =>
            {
                entity.HasKey(e => e.AppType);

                entity.ToTable("xref_AppType");

                entity.Property(e => e.AppType)
                    .HasMaxLength(50)
                    .HasColumnName("appType");

                entity.Property(e => e.AppTypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("appTypeID");
            });

            modelBuilder.Entity<XrefIdxref>(entity =>
            {
                entity.HasKey(e => e.IdXrefId);

                entity.ToTable("xref_IDXRef");

                entity.HasIndex(e => e.IdXref, "IX_xref_IDXRef_1");

                entity.Property(e => e.IdXrefId).HasColumnName("idXRefID");

                entity.Property(e => e.IdXref)
                    .HasMaxLength(50)
                    .HasColumnName("idXRef");
            });

            modelBuilder.Entity<XrefIdxrefData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xref_IDXRefData");

                entity.HasIndex(e => new { e.IdXrefId, e.AppInstanceId, e.AppId, e.CommonId }, "CIX_xref_IDXRefData")
                    .IsClustered();

                entity.HasIndex(e => new { e.AppId, e.IdXrefId, e.AppInstanceId }, "IX_xref_IDXRefData_appID")
                    .IsUnique();

                entity.HasIndex(e => new { e.CommonId, e.IdXrefId, e.AppInstanceId }, "IX_xref_IDXRefData_commonID")
                    .IsUnique();

                entity.Property(e => e.AppId)
                    .HasMaxLength(255)
                    .HasColumnName("appID");

                entity.Property(e => e.AppInstanceId).HasColumnName("appInstanceID");

                entity.Property(e => e.CommonId)
                    .HasMaxLength(50)
                    .HasColumnName("commonID");

                entity.Property(e => e.IdXrefId).HasColumnName("idXRefID");
            });

            modelBuilder.Entity<XrefMessageArgument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xref_MessageArgument");

                entity.HasIndex(e => new { e.MsgId, e.ArgSequenceNum }, "CX_xref_MessageArgument")
                    .IsClustered();

                entity.Property(e => e.ArgIdxrefId).HasColumnName("argIDXRefID");

                entity.Property(e => e.ArgName)
                    .HasMaxLength(50)
                    .HasColumnName("argName");

                entity.Property(e => e.ArgSequenceNum).HasColumnName("argSequenceNum");

                entity.Property(e => e.ArgValueXrefId).HasColumnName("argValueXRefID");

                entity.Property(e => e.MsgId).HasColumnName("msgID");
            });

            modelBuilder.Entity<XrefMessageDef>(entity =>
            {
                entity.HasKey(e => e.MsgId)
                    .HasName("PK_uan_MessageDef");

                entity.ToTable("xref_MessageDef");

                entity.HasIndex(e => e.MsgCode, "IX_xref_MessageDef_1");

                entity.Property(e => e.MsgId).HasColumnName("msgID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.MsgCode)
                    .HasMaxLength(50)
                    .HasColumnName("msgCode");
            });

            modelBuilder.Entity<XrefMessageText>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xref_MessageText");

                entity.HasIndex(e => new { e.Lang, e.MsgId }, "CX_xref_MessageText_1")
                    .IsClustered();

                entity.Property(e => e.Lang)
                    .HasMaxLength(10)
                    .HasColumnName("lang");

                entity.Property(e => e.MsgId).HasColumnName("msgID");

                entity.Property(e => e.MsgText)
                    .HasMaxLength(1000)
                    .HasColumnName("msgText");
            });

            modelBuilder.Entity<XrefValueXref>(entity =>
            {
                entity.HasKey(e => e.ValueXrefId);

                entity.ToTable("xref_ValueXRef");

                entity.HasIndex(e => e.ValueXrefName, "IX_xref_ValueXRef_1");

                entity.Property(e => e.ValueXrefId).HasColumnName("valueXRefID");

                entity.Property(e => e.ValueXrefName)
                    .HasMaxLength(50)
                    .HasColumnName("valueXRefName");
            });

            modelBuilder.Entity<XrefValueXrefData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xref_ValueXRefData");

                entity.HasIndex(e => e.CommonValue, "IX_xref_ValueXRefData_1");

                entity.HasIndex(e => e.AppValue, "IX_xref_ValueXRefData_2");

                entity.Property(e => e.AppTypeId).HasColumnName("appTypeID");

                entity.Property(e => e.AppValue)
                    .HasMaxLength(50)
                    .HasColumnName("appValue");

                entity.Property(e => e.CommonValue)
                    .HasMaxLength(50)
                    .HasColumnName("commonValue");

                entity.Property(e => e.ValueXrefId).HasColumnName("valueXRefID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
