﻿using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Tudou.Abp.AuditLogging.MongoDB
{
    [ConnectionStringName(AbpAuditLoggingDbProperties.ConnectionStringName)]
    public interface IAuditLoggingMongoDbContext : IAbpMongoDbContext
    {
        IMongoCollection<AuditLog> AuditLogs { get; }
    }
}
