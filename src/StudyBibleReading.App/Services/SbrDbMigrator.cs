﻿using Microsoft.EntityFrameworkCore;
using StudyBibleReading.Domain.Models;
using StudyBibleReading.Infra.Context;

namespace StudyBibleReading.App.Services
{
    public class SbrDbMigrator(IDbContextFactory<SbrContext> dbContextFactory)
    {
        private const string APP_SETTING_DB_VERSION = "DbVersion";
        private const string CurrentDbVersion = "1.0";
        private SbrContext dbContext = null!;

        public async Task<string> EnsureDbCreated()
        {
            dbContext = await dbContextFactory.CreateDbContextAsync();

            // uncomment the following lines to see the CREATE TABLE
            // scripts in the browser console when generating a new
            // database - this is useful when creating new migrations
            var dbCreationSql = dbContext.Database.GenerateCreateScript();
            Console.WriteLine("Db Creation SQL:");
            Console.WriteLine(dbCreationSql);

            _ = await dbContext.Database.EnsureCreatedAsync();
            var dbVersionAppSetting = await dbContext.ApplicationSettings.FirstOrDefaultAsync(x => x.Key == APP_SETTING_DB_VERSION);
            var dbVersion = await EnsureDbMigratedAsync(dbVersionAppSetting?.Value!);

            return dbVersion;
        }

        public async Task DeleteDatabase()
        {
            dbContext = await dbContextFactory.CreateDbContextAsync();
            _ = await dbContext.Database.EnsureDeletedAsync();
        }

        private async Task<string> EnsureDbMigratedAsync(string dbVersion)
        {
            if (dbVersion == CurrentDbVersion)
            {
                return dbVersion;
            }

            if (dbVersion is null)
            {
                await ApplyDbVersionAsync(CurrentDbVersion);
                return CurrentDbVersion;
            }

            //if (dbVersion == "1.0")
            //{
            //    await Migrate_101_TaskListItems();
            //    await Migrate_102_CodeSnippets();
            //    await Migrate_103_Links();
            //    dbVersion = CurrentDbVersion;
            //}

            //if (dbVersion == "1.01")
            //{
            //    await Migrate_102_CodeSnippets();
            //    await Migrate_103_Links();
            //    dbVersion = CurrentDbVersion;
            //}

            //if (dbVersion == "1.02")
            //{
            //    await Migrate_103_Links();
            //    dbVersion = CurrentDbVersion;
            //}
            return dbVersion;
        }

        private async Task ApplyDbVersionAsync(string dbVersion)
        {
            var appSettingDbVersion = dbContext.ApplicationSettings.SingleOrDefault(x => x.Key == APP_SETTING_DB_VERSION);
            if (appSettingDbVersion is not null)
            {
                appSettingDbVersion.Value = dbVersion;
            }
            else
            {
                dbContext.ApplicationSettings.Add(new ApplicationSetting { Key = APP_SETTING_DB_VERSION, Value = dbVersion });
            }

            await dbContext.SaveChangesAsync();
        }

        //private async Task Migrate_101_TaskListItems()
        //{
        //    const string Create_Table_Task_List_Items = @"CREATE TABLE ""TaskListItems"" (
        //        ""Id"" INTEGER NOT NULL CONSTRAINT ""PK_TaskListItems"" PRIMARY KEY AUTOINCREMENT,
        //        ""CategoryId"" INTEGER NULL,
        //        ""ProjectId"" INTEGER NULL,
        //        ""Narrative"" TEXT NULL,
        //        ""Priority"" INTEGER NOT NULL,
        //        ""Status"" INTEGER NOT NULL,
        //        ""Due"" TEXT NULL
        //    );";

        //    _ = await _dbContext.Database.ExecuteSqlRawAsync(Create_Table_Task_List_Items);
        //    await ApplyDbVersionAsync("1.01");
        //}

        //private async Task Migrate_102_CodeSnippets()
        //{
        //    const string Create_Table_CODE_SNIPPETS = @"CREATE TABLE ""CodeSnippets"" (
        //        ""Id"" INTEGER NOT NULL CONSTRAINT ""PK_CodeSnippets"" PRIMARY KEY AUTOINCREMENT,
        //        ""Label"" TEXT NULL,
        //        ""Content"" TEXT NULL,
        //        ""Language"" TEXT NULL,
        //        ""SourceUrl"" TEXT NULL
        //    );";

        //    _ = await _dbContext.Database.ExecuteSqlRawAsync(Create_Table_CODE_SNIPPETS);
        //    await ApplyDbVersionAsync("1.02");
        //}

        //private async Task Migrate_103_Links()
        //{
        //    const string Create_Table_LINKS = @"CREATE TABLE ""Links"" (
        //        ""Id"" INTEGER NOT NULL CONSTRAINT ""PK_Links"" PRIMARY KEY AUTOINCREMENT,
        //        ""Url"" TEXT NULL,
        //        ""Label"" TEXT NULL,
        //        ""Description"" TEXT NULL
        //    );";

        //    _ = await _dbContext.Database.ExecuteSqlRawAsync(Create_Table_LINKS);
        //    await ApplyDbVersionAsync("1.03");
        //}
    }
}
