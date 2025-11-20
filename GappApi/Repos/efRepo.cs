using GappApi.Data;
using GappApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GappApi.Repos
{
    public class efRepo
    {
        private readonly AppDbContext dbContext;

        public efRepo(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<List<BtsOrchestration>> getOrchestrations(){
            List<BtsOrchestration> list = await dbContext.BtsOrchestration.AsNoTracking().ToListAsync();
            return list;
        }

        public async Task<List<BtsOrchestration>> getFullOrchestration(int? id = null)
        {
            var query = dbContext.BtsOrchestration
                .Include(o => o.BtsOrchestrationPort)
                    .ThenInclude(p => p.BtsOrchestrationPortBinding)
                        .ThenInclude(a => a.NReceivePort)
                            .ThenInclude(s => s.AdmReceiveLocation)
                                .ThenInclude(b => b.ReceivePipeline)
                .Include(o => o.BtsOrchestrationPort)
                    .ThenInclude(p => p.BtsOrchestrationPortBinding)
                        .ThenInclude(a => a.NSendPort)
                            .ThenInclude(s => s.BtsSendportTransport)
                .Include(o => o.BtsOrchestrationPort)
                    .ThenInclude(p => p.BtsOrchestrationPortBinding)
                        .ThenInclude(a => a.NSendPort)
                            .ThenInclude(s => s.NSendPipeline)
                .AsNoTracking();
            
            if (id != null)
                query = query.Where(a => a.NId == id);
            
            var list = await query.ToListAsync();
            return list;
        }

        public async Task<List<BusinessProfile>> getFullTradingPartners(int? id = null){
            var query = dbContext.BusinessProfile
                .Include(o => o.Partner)
                .Include(o => o.BusinessIdentity)
                .Include(o => o.ProtocolSettings)
                .AsNoTracking();

            if (id != null)
                query = query.Where(a => a.ProfileId == id);
            
            var list = await query.ToListAsync();
            return list;
        }

        public async Task<List<Agreement>> getFullAgreements(int? id = null){
            var query = dbContext.Agreement
                .Include(o => o.Contact)
                .Include(o => o.ReceiverProtocolSettings)
                .Include(o => o.SenderProtocolSettings)
                .Include(o => o.Partnership)
                    .ThenInclude(a => a.PartnerA)
                .Include(o => o.Partnership)
                    .ThenInclude(a => a.PartnerB)
                .AsNoTracking();

            if (id != null)
                query = query.Where(a => a.Id == id);
            
            var list = await query.ToListAsync();
            return list;
        }

        public async Task<List<X12protocolSettings>> getFullX12Protocols(int? id = null){
            var query = dbContext.X12protocolSettings
                .Include(o => o.X12schemaOverrides)
                .Include(o => o.X12envelopesOverrides)
                .AsNoTracking();

            if (id != null)
                query = query.Where(a => a.SettingsId == id);
            
            var list = await query.ToListAsync();
            return list;
        }

        public async Task<List<AdmAdapter>> getAdapters(int? id = null){
            var query = dbContext.AdmAdapter
                .AsNoTracking();

            if (id != null)
                query = query.Where(a => a.Id == id);
            
            var list = await query.ToListAsync();
            return list;
        }

        public async Task<List<AdmAdapterAlias>> getAdapterAlias(int? id = null){
            var query = dbContext.AdmAdapterAlias
                .AsNoTracking();

            if (id != null)
                query = query.Where(a => a.Id == id);
            
            var list = await query.ToListAsync();
            return list;
        }

        public async Task<List<BtsComponent>> getComponent(int? id = null){
            var query = dbContext.BtsComponent
                .AsNoTracking();

            if (id != null)
                query = query.Where(a => a.Id == id);
            
            var list = await query.ToListAsync();
            
            return list;
        }
    }
}